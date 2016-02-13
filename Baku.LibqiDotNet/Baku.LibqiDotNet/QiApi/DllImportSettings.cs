﻿namespace Baku.LibqiDotNet
{
    /// <summary>アンマネージドライブラリの読み込み設定です。</summary>
    public static class DllImportSettings
    {
        /// <summary>ライブラリが読み込む予定のアンマネージドDLLファイルの名前</summary>
#if UNITY
        public const string DllName = @"qic";
#else
        public const string DllName = @"qic.dll";
#endif
    }
}
