using UnityEngine;

public class Paddle : MonoBehaviour
{
    // 1. DEKLARASI (Mengenalkan variabel)
    [SerializeField] private float speed = 10f;
    [SerializeField] private bool isAI = false;

    private Rigidbody2D rb;
    private Transform ball;

    // 2. START (Berjalan 1x saat game mulai)
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // AI mencari bola berdasarkan Tag yang kita buat tadi
        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball");
        if (ballObject != null)
        {
            ball = ballObject.transform;
        }
    }

    // 3. FIXED UPDATE (Untuk gerakan fisika agar mulus)
    void FixedUpdate()
    {
        if (isAI)
        {
            MoveAI();
        }
        else
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        float moveInput = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(0, moveInput * speed);
    }

    void MoveAI()
    {
        if (ball == null) return;

        // Jika bola di atas paddle, gerak ke atas. Jika di bawah, gerak ke bawah.
        if (ball.position.y > transform.position.y + 0.5f)
        {
            rb.linearVelocity = new Vector2(0, speed * 0.8f);
        }
        else if (ball.position.y < transform.position.y - 0.5f)
        {
            rb.linearVelocity = new Vector2(0, -speed * 0.8f);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}