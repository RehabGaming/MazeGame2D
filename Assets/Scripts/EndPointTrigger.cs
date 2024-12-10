using UnityEngine;
using UnityEngine.SceneManagement; // ���� ����� ��� �����

public class EndPointTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ����� �� �������� ����� ��� �����
        if (collision.gameObject.CompareTag("Player"))
        {
            // ���� ���� �������
            EndGame();
        }
    }

    private void EndGame()
    {
        // ���� �� ����� �� �������
        SceneManager.LoadScene("VictoryScene");
    }
}
