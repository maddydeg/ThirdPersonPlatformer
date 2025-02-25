using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private Rigidbody rb;
    private bool onGround;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        inputManager.onSpacePressed.AddListener(PlayerJump);
        rb = GetComponent<Rigidbody>();
    }
    
    //MovePlayer is called when W, A, S, D and/or space is pressed 
    void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new(direction.x, 0f, direction.y);
        rb.AddForce(speed * moveDirection);
    }   

    void PlayerJump()
    {
        Debug.Log("Player Jump ran!");
        if (onGround == true)
        {
            Debug.Log("Player Jump force added!");
            rb.AddForce(Vector3.up * jumpForce);
        } 

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter ran!");
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("onGround set to true");
            onGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }
}
