using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreenManager : MonoBehaviour
{
    public void LoadMainScene()
    {
        // טוען את הסצנה הראשית מחדש
        SceneManager.LoadScene("FirstLevelScene");
    }
}
