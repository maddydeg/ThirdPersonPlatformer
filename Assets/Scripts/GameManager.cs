using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    public static GameManager Instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void AddScore()
    {
        score++;
        Debug.Log("Score updated to: " + score);
    }
}
