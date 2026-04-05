using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialSpeed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    public void LaunchBall()
    {
        // Reset posisi ke tengah
        transform.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;

        // Pilih arah acak (Kiri atau Kanan)
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-0.5f, 0.5f); // Menghindari sudut yang terlalu curam

        Vector2 direction = new Vector2(x, y).normalized;
        rb.AddForce(direction * initialSpeed, ForceMode2D.Impulse);
    }
}