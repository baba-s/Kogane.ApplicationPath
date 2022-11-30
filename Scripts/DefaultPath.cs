using UnityEngine;

namespace Kogane.Internal
{
    /// <summary>
    /// デフォルトのプラットフォームにおけるディレクトリのパスを返すインターフェイス
    /// </summary>
    internal sealed class DefaultPath : IPath
    {
        //================================================================================
        // プロパティ
        //================================================================================
        /// <summary>
        /// 永続的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string IPath.PersistentDataPath => Application.persistentDataPath;

        /// <summary>
        /// 一時的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string IPath.TemporaryCachePath => Application.temporaryCachePath;
    }
}