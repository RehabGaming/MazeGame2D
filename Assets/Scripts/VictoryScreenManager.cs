using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreenManager : MonoBehaviour
{
    public void LoadMainScene()
    {
        // ���� �� ����� ������ ����
        SceneManager.LoadScene("FirstLevelScene");
    }
}
