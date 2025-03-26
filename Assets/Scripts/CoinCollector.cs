using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    
    private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Coin"))
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject); 
        }
    }
}

