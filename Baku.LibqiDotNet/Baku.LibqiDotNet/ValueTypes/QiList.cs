﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Baku.LibqiDotNet
{
    /// <summary>可変な配列型を表します。配列は単調に伸びる処理だけが許可されています。</summary>
    public class QiList<T> : QiAnyValue
        where T : QiAnyValue
    {
        private QiList(QiValue value, string sig)
        {
            QiValue = value;
            Signature = sig;
        }

        public override QiValue QiValue { get; }

        public override string Signature { get; }

        public int Count => QiValue.Count;

        public QiValue this[int i]
        {
            get { return this.QiValue[i]; }
            set { this.QiValue[i] = value; }
        }

        /// <summary>
        /// 列挙された<see cref="QiAnyValue"/>派生型から、それに対応したリストを生成します。
        /// </summary>
        /// <param name="values">何かしらの値の列挙</param>
        /// <returns></returns>
        public static QiList<T> Create(IEnumerable<T> values)
        {
            if (!values.Any())
            {
                throw new InvalidOperationException("values length must be greater than 0");
            }

            //リストは中身のシグネチャ揃ってないとアウト(ダイナミックリストの場合は例外)
            string elemSig = values.First().Signature;
            if (values.Any(v => v.Signature != elemSig))
            {
                throw new InvalidOperationException("values kind is not same");
            }

            string sig = QiSignatures.TypeListBegin + elemSig + QiSignatures.TypeListEnd;

            var list = QiValue.Create(sig);
            foreach (var v in values)
            {
                list.AddElement(v.QiValue);
            }

            return new QiList<T>(list, sig);
        }

    }

    /// <summary><see cref="QiList"/>を扱いやすくするための拡張メソッドを定義します。</summary>
    public static class QiListExtension
    {
        /// <summary>
        /// IEnumerableを対応する<see cref="QiList"/>に変換します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static QiList<T> ToQiList<T>(this IEnumerable<T> values)
            where T : QiAnyValue
            => QiList<T>.Create(values);
    }
}