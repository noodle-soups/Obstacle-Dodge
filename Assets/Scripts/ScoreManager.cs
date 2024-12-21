using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int playerHitScore = 3;
    PlayerMovement playerMovementScript;

    private void Start()
    {
        playerMovementScript = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        KillState();
    }

    private void KillState()
    {
        if (playerHitScore == 0)
        {
            playerMovementScript.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            playerHitScore -= 1;
            Debug.Log("Score: " + playerHitScore);
        }
    }

}
