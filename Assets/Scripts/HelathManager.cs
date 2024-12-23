using UnityEngine;

public class HelathManager : MonoBehaviour
{

    public int playerHealth = 3;
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
        if (playerHealth == 0)
        {
            playerMovementScript.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            playerHealth -= 1;
            Debug.Log("Health: " + playerHealth);
        }
    }

}
