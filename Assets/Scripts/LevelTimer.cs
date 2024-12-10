using UnityEngine;
using TMPro; // דרוש כדי לעבוד עם TextMeshPro

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText; // טקסט מסוג TextMeshPro
    public float timeLimit = 60f; // זמן מוקצב בשניות

    private float timeRemaining;

    private void Start()
    {
        timeRemaining = timeLimit; // אתחול הזמן
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            // הפחתת הזמן
            timeRemaining -= Time.deltaTime;

            // עדכון הטקסט של הזמן
            timerText.text = "Time Left: " + Mathf.Ceil(timeRemaining).ToString();
        }
        else
        {
            // הזמן נגמר - תוכל להוסיף מעבר לסצנה אחרת
            Debug.Log("Time's up!");
        }
    }
}
