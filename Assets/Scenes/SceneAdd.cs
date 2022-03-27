using UnityEngine;
using UnityEngine.SceneManagement;  // 追加

public class SceneAdd : MonoBehaviour
{
	/// <summary>ボタンをクリックしたときに呼ばれます。</summary>
	public void OnClick()
	{
		// 指定したシーンを追加します
		SceneManager.LoadScene("SampleSceneChild", LoadSceneMode.Additive);
	}
}
