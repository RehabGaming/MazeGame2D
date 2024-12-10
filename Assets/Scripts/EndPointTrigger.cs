using UnityEngine;
using UnityEngine.SceneManagement; // נדרש למעבר בין סצנות

public class EndPointTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // בדיקה אם האובייקט שנכנס הוא השחקן
        if (collision.gameObject.CompareTag("Player"))
        {
            // מעבר למסך הניצחון
            EndGame();
        }
    }

    private void EndGame()
    {
        // טוען את הסצנה של הניצחון
        SceneManager.LoadScene("VictoryScene");
    }
}
