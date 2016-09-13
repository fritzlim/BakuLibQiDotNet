﻿using Baku.LibqiDotNet;
using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using Baku.LibqiDotNet.Path;
using Baku.LibqiDotNet.Service;

namespace Test.Baku.LibqiDotNet
{
    public abstract class CommonTestWithServices
    {
        protected abstract QiSession GetConnectedSession();

        protected QiSession Session { get; private set; }

        public virtual void SetUpConnection()
        {
            PathModifier.AddEnvironmentPath("dlls", PathModifyMode.RelativeToExecutingAssembly);
            Session = GetConnectedSession();
            //接続でコケたらテストに進まない(当たり前)
            Assert.IsTrue(Session.IsConnected);
        }

        public virtual void CloseAllConnection()
        {
            Session?.Close();
        }

        public virtual void TestMotionSummary()
        {
            var motion = ALMotion.CreateService(Session);
            string summary = motion.GetSummary();

            //"summary" must contain multi-line information string (off course NOT empty)
            Assert.IsTrue(summary.Split('\n').Length > 1);
        }

        public virtual void TestArrayResult()
        {
            double[] angles = ALMotion.CreateService(Session).GetAngles("Body", true).Get<double[]>();
            if (angles.Length == 0)
            {
                Assert.Fail("Received zero-length float[] for robot angles.");
            }
            //check if value is not default.
            for (int i = 0;i < angles.Length; i++)
            {
                if (angles[i] != 0)
                {
                    Assert.Pass("Success, non-zero value was returned as robot's angle");
                }
            }
        }

        public virtual void TestDialogEvents()
        {
            Assert.IsTrue(DialogEventWithServices.TryDetectSignalEvent(Session));
        }

        public virtual void TestMotionPose()
        {
            var motion = ALMotion.CreateService(Session);
            var posture = ALRobotPosture.CreateService(Session);

            motion.WakeUp();
            posture.GoToPosture("StandInit", 0.5f);
        }

        public virtual void TestMemoryData()
        {
            var memory = ALMemory.CreateService(Session);

            //memory data functionality
            string memKey = "MyApplication/MyData";
            int testInput = 42;

            //CRAD-like
            memory.InsertData(memKey, testInput);
            int testOutput = memory.GetData(memKey).Get<int>();
            memory.RemoveData(memKey);

            Assert.AreEqual(testInput, testOutput);
        }

        public virtual void TestMemoryEvent()
        {
            int testInput = 42;
            string eventName = "MyApplication/MyEvent";

            //be true if event handler was called successfully
            bool isHandlerCorrectlyCalled = false;
            EventHandler<QiSignalEventArgs> onReceiveSignal = (_, e) =>
            {
                if (e.Data.Count > 0 && e.Data[0].ToInt32() == testInput)
                {
                    isHandlerCorrectlyCalled = true;
                }
            };

            var memory = ALMemory.CreateService(Session);

            IQiSignal signal = memory.Subscriber(eventName);
            signal.Received += onReceiveSignal;
            //wait for handler register completed (↑ line actually does things async)
            Thread.Sleep(100);

            memory.RaiseEvent(eventName, testInput);

            //wait for event message (there might took some time to arrive message)
            Thread.Sleep(100);

            signal.Received -= onReceiveSignal;
            memory.RemoveEvent(eventName);

            Assert.IsTrue(isHandlerCorrectlyCalled);
        }

        public virtual void TestMemoryKeyList()
        {
            var memory = ALMemory.CreateService(Session);

            string[] memoryDataKeys = memory.GetDataListName();
            Assert.IsTrue(memoryDataKeys.Length > 0);

            string[] memoryEventKeys = memory.GetEventList();
            Assert.IsTrue(memoryEventKeys.Length > 0);
        }

        public virtual void TestSensors()
        {
            Assert.Fail("Pass this test because simulator does not support sensor data I/O");
            SensorsWithServices.GetIMUData(Session);
            SensorsWithServices.GetSonarData(Session);
            Assert.Pass("Sensor data download function ends with no exceptions");
        }

        public virtual void TestHelloWorld()
        {
            ALTextToSpeech.CreateService(Session).Say("Hello, World");
        }

        public virtual void TestBinaryOutput()
        {
            var vd = ALVideoDevice.CreateService(Session);

            //忌々しいマジックナンバーを使っているが、パラメタについては
            //ALVideoDevice::subscribeのドキュメンテーションに載っているので参照されたく。
            //http://doc.aldebaran.com/2-1/naoqi/vision/alvideodevice-api.html?highlight=alvideodevice#ALVideoDeviceProxy::subscribeCamera__ssCR.iCR.iCR.iCR.iCR
            string idName = vd.SubscribeCamera("mytestimage",
                //カメラ種類 0:正面, 1:下方, 2:深度
                0,
                //解像度 1:320x240
                1,
                //色空間 11が24bit RGBなので基本コレでいいがYUVの方が速度速そうみたいな話もあるので注意
                11,
                //FPS: 1から30くらいまで
                5
                );

            //画像がデータバッファに溜まるのを確実に待機
            Thread.Sleep(500);

            try
            {
                byte[] res = vd.GetImageRemote(idName)[6].ToBytes();
                Assert.IsTrue(res.Length == 320 * 240 * 3);
            }
            finally
            {
                vd.Unsubscribe(idName);
            }

        }

        public virtual void TestNotFoundMethod()
        {
            try
            {
                ALTextToSpeech.CreateService(Session).SourceService["SomeNotExistNameFunction"].Call();
            }
            catch (KeyNotFoundException)
            {
                Assert.Pass("success to detect an invalid method name");
            }

            Assert.Fail("could not detect exception correctly");
        }

        public virtual void TestComplicatedArg()
        {
            var motion = ALMotion.CreateService(Session);

            motion.WakeUp();

            var jointNames = new string[] { "HeadYaw", "HeadPitch" };
            var angles = new float[][]
            {
                new float[] { (float)(50.0 * Math.PI / 180.0), 0 },
                new float[] { (float)(-30.0 * Math.PI / 180.0), (float)(30 * Math.PI / 180.0), 0 }
            };

            var times = new float[][]
            {
                new float[] { 1, 2 },
                new float[] { 1, 2, 3 }
            };

            bool isAbsolute = true;

            motion.AngleInterpolation(jointNames, angles, times, isAbsolute);
        }
    }
}
