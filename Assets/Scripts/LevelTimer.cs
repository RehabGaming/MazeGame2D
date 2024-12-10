using UnityEngine;
using TMPro; // ���� ��� ����� �� TextMeshPro

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText; // ���� ���� TextMeshPro
    public float timeLimit = 60f; // ��� ����� ������

    private float timeRemaining;

    private void Start()
    {
        timeRemaining = timeLimit; // ����� ����
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            // ����� ����
            timeRemaining -= Time.deltaTime;

            // ����� ����� �� ����
            timerText.text = "Time Left: " + Mathf.Ceil(timeRemaining).ToString();
        }
        else
        {
            // ���� ���� - ���� ������ ���� ����� ����
            Debug.Log("Time's up!");
        }
    }
}
