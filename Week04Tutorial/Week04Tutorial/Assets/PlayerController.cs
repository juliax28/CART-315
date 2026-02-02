using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 10f;

    Rigidbody2D rb;

    public event Action PlayerDied
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Object"))
        {
            PLayerDied.Invoke();
            Destroy(this.gameObject);
        }
    }
}
