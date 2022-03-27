using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChildSceneCamera : MonoBehaviour
{
  /// <summary>シーンに追加されたタイミングで処理されます。</summary>
  void Awake()
  {
    // 親のシーンのキャンバスを取得
    var parentScene = SceneManager.GetSceneByName("SampleSceneParent");
    var parentCanvas = parentScene.GetRootGameObjects().First(obj => obj.GetComponent<Canvas>() != null).GetComponent<Canvas>();

    // 子のシーンのキャンバスを取得
    var childCanvas = GetComponent<Canvas>();

    // 子のシーンのカメラを削除
    Object.Destroy(childCanvas.worldCamera.gameObject);

    // 子のシーンのキャンバスのカメラを親のシーンのカメラに置き換えます
    childCanvas.worldCamera = parentCanvas.worldCamera;
  }
}
