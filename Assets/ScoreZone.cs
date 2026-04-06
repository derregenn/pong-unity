using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public bool isPlayerGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            GameManager.instance.AddScore(isPlayerGoal);
            collision.GetComponent<Ball>().Launch();
        }
    }
}