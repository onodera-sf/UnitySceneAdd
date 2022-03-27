using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChildSceneCamera : MonoBehaviour
{
  /// <summary>�V�[���ɒǉ����ꂽ�^�C�~���O�ŏ�������܂��B</summary>
  void Awake()
  {
    // �e�̃V�[���̃L�����o�X���擾
    var parentScene = SceneManager.GetSceneByName("SampleSceneParent");
    var parentCanvas = parentScene.GetRootGameObjects().First(obj => obj.GetComponent<Canvas>() != null).GetComponent<Canvas>();

    // �q�̃V�[���̃L�����o�X���擾
    var childCanvas = GetComponent<Canvas>();

    // �q�̃V�[���̃J�������폜
    Object.Destroy(childCanvas.worldCamera.gameObject);

    // �q�̃V�[���̃L�����o�X�̃J������e�̃V�[���̃J�����ɒu�������܂�
    childCanvas.worldCamera = parentCanvas.worldCamera;
  }
}
