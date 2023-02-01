﻿#if UNITY_EDITOR || UNITY_ANDROID

using JetBrains.Annotations;
using UnityEngine;

namespace Kogane.Internal
{
    /// <summary>
    /// Android におけるディレクトリのパスを返すインターフェイス
    /// </summary>
    [UsedImplicitly]
    internal sealed class AndroidPath : IPath
    {
        //================================================================================
        // プロパティ
        //================================================================================
        /// <summary>
        /// 永続的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string IPath.PersistentDataPath
        {
            get
            {
                using var player   = new AndroidJavaClass( "com.unity3d.player.UnityPlayer" );
                using var activity = player.GetStatic<AndroidJavaObject>( "currentActivity" );
                using var file     = activity.Call<AndroidJavaObject>( "getFilesDir" );
                return file == null ? string.Empty : file.Call<string>( "getAbsolutePath" );
            }
        }

        /// <summary>
        /// 一時的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string IPath.TemporaryCachePath
        {
            get
            {
                using var player   = new AndroidJavaClass( "com.unity3d.player.UnityPlayer" );
                using var activity = player.GetStatic<AndroidJavaObject>( "currentActivity" );
                using var file     = activity.Call<AndroidJavaObject>( "getCacheDir" );
                return file == null ? string.Empty : file.Call<string>( "getAbsolutePath" );
            }
        }
    }
}

#endif