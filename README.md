# Kogane Application Path

データを保存できるディレクトリのパスを管理するクラス

## 使用例

```cs
using Kogane;
using System.IO;
using UnityEngine;

public class Example : MonoBehaviour
{
    private string m_text = string.Empty;

    private void OnGUI()
    {
        GUILayout.Label( ApplicationPath.PersistentDataPath );
        GUILayout.Label( ApplicationPath.TemporaryCachePath );
        GUILayout.Label( m_text );
    }

    public void Save()
    {
        File.WriteAllText( ApplicationPath.PersistentDataPath + "/test.txt", "ピカチュウ" );
    }

    public void Load()
    {
        m_text = File.ReadAllText( ApplicationPath.PersistentDataPath + "/test.txt" );
    }
}
```