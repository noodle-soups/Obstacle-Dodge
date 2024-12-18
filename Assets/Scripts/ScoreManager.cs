using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    int playerHitScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        playerHitScore += 1;
        Debug.Log("Score: " + playerHitScore);
    }

}
