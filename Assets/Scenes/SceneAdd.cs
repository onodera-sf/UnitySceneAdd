using UnityEngine;
using UnityEngine.SceneManagement;  // �ǉ�

public class SceneAdd : MonoBehaviour
{
	/// <summary>�{�^�����N���b�N�����Ƃ��ɌĂ΂�܂��B</summary>
	public void OnClick()
	{
		// �w�肵���V�[����ǉ����܂�
		SceneManager.LoadScene("SampleSceneChild", LoadSceneMode.Additive);
	}
}
