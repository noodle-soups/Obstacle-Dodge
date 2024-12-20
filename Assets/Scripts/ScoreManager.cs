using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int playerHitScore = 3;
    Mover moverScript;

    private void Start()
    {
        moverScript = GetComponent<Mover>();
    }

    private void Update()
    {
        KillState();
    }

    private void KillState()
    {
        if (playerHitScore == 0)
        {
            moverScript.enabled = false;
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
