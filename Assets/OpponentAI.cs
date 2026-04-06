using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    public void Launch()
    {
        transform.position = Vector2.zero;

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);

        Vector2 dir = new Vector2(x, y).normalized;
        rb.linearVelocity = dir * speed;
    }
}