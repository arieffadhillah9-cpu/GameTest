using UnityEngine;
using UnityEngine.Events;

public class GoalZone : MonoBehaviour
{
    [SerializeField] private UnityEvent onGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            // Memicu event (Observer Pattern)
            onGoal.Invoke();
        }
    }
}