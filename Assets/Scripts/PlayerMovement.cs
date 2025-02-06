using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{ 
    [SerializeField] private float speed;
    private Rigidbody2D body;
 
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
 
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
 
        if(Input.GetKey(KeyCode.W))
            body.velocity = new Vector2(body.velocity.x, speed);

        if(Input.GetKey(KeyCode.LeftShift))
            body.velocity = new Vector2(Input.GetAxis("Horizontal") * 20, body.velocity.y);
    }
}
