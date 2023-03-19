#if UNITY_EDITOR || UNITY_ANDROID

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
        // 変数
        //================================================================================
        private string m_persistentDataPathCache;
        private string m_temporaryCachePathCache;

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
                if ( m_persistentDataPathCache != null ) return m_persistentDataPathCache;

                using var player   = new AndroidJavaClass( "com.unity3d.player.UnityPlayer" );
                using var activity = player.GetStatic<AndroidJavaObject>( "currentActivity" );
                using var file     = activity.Call<AndroidJavaObject>( "getFilesDir" );

                m_persistentDataPathCache = file == null ? string.Empty : file.Call<string>( "getAbsolutePath" );

                return m_persistentDataPathCache;
            }
        }

        /// <summary>
        /// 一時的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string IPath.TemporaryCachePath
        {
            get
            {
                if ( m_temporaryCachePathCache != null ) return m_temporaryCachePathCache;

                using var player   = new AndroidJavaClass( "com.unity3d.player.UnityPlayer" );
                using var activity = player.GetStatic<AndroidJavaObject>( "currentActivity" );
                using var file     = activity.Call<AndroidJavaObject>( "getCacheDir" );

                m_temporaryCachePathCache = file == null ? string.Empty : file.Call<string>( "getAbsolutePath" );

                return m_temporaryCachePathCache;
            }
        }
    }
}

#endif