using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // מהירות התנועה של השחקן
    private Rigidbody2D rb; // משתנה לאחסון ה-Rigidbody2D של השחקן
    private Vector2 movement; // משתנה לאחסון וקטור התנועה

    private void Start()
    {
        // אתחול המשתנה rb באמצעות ה-Rigidbody2D שמחובר לאובייקט
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // קבלת הקלט מהשחקן עבור צירי התנועה
        float moveX = Input.GetAxis("Horizontal"); // תנועה בציר האופקי (ימינה ושמאלה)
        float moveY = Input.GetAxis("Vertical"); // תנועה בציר האנכי (למעלה ולמטה)

        // יצירת וקטור תנועה המבוסס על הקלט מהשחקן
        movement = new Vector2(moveX, moveY);
    }

    private void FixedUpdate()
    {
        // עדכון המהירות של ה-Rigidbody2D באמצעות הוקטור והמהירות
        rb.linearVelocity = movement * speed;
    }
}
