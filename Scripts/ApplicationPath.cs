namespace Kogane
{
	/// <summary>
	/// <para>データを保存できるディレクトリのパスを管理するクラス</para>
	/// <para>ユーザーがアクセスできない領域にデータを保存したい場合に使用します</para>
	/// </summary>
	public static class ApplicationPath
	{
		//================================================================================
		// 変数(static readonly)
		//================================================================================
		private static readonly IPath ms_path =
#if !UNITY_EDITOR && UNITY_ANDROID
			new AndroidPath();
#else
			new DefaultPath();
#endif
		
		//================================================================================
		// プロパティ(static)
		//================================================================================
		/// <summary>
		/// 永続的にデータを保存できるディレクトリのパスを返します
		/// </summary>
		public static string PersistentDataPath => ms_path.PersistentDataPath;

		/// <summary>
		/// 一時的にデータを保存できるディレクトリのパスを返します
		/// </summary>
		public static string TemporaryCachePath => ms_path.TemporaryCachePath;
	}
}