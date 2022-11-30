namespace Kogane
{
    /// <summary>
    /// ディレクトリのパスを返すインターフェイス
    /// </summary>
    internal interface IPath
    {
        //================================================================================
        // プロパティ
        //================================================================================
        /// <summary>
        /// 永続的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string PersistentDataPath { get; }

        /// <summary>
        /// 一時的にデータを保存できるディレクトリのパスを返します
        /// </summary>
        string TemporaryCachePath { get; }
    }
}