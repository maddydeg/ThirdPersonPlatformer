using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float rotateSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player touched a coin");
            //TODO: Implement score increase
            GameManager.Instance.AddScore();
            //Destroy the coin
            Destroy(gameObject);
        }
    }
    
}
