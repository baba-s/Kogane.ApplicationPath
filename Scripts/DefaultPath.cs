using UnityEngine;

namespace UniApplicationPath
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
		public string PersistentDataPath => Application.persistentDataPath;

		/// <summary>
		/// 一時的にデータを保存できるディレクトリのパスを返します
		/// </summary>
		public string TemporaryCachePath => Application.temporaryCachePath;
	}
}