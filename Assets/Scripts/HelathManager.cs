using UnityEngine;

public class HelathManager : MonoBehaviour
{

    public int playerHealth = 3;
    PlayerMovement playerMovementScript;
    [SerializeField] private bool readyToDestroy;
    private float killRotation = 1000;

    private void Start()
    {
        playerMovementScript = GetComponent<PlayerMovement>();
        readyToDestroy = false;
    }

    private void Update()
    {
        HandleDeath();
    }

    private void HandleDeath()
    {
        PlayerEntersDeathState();
        DestroyPlayer();
    }

    private void PlayerEntersDeathState()
    {
        if (playerHealth == 0)
        {
            playerMovementScript.enabled = false;
            readyToDestroy = true;
        }
    }

    private void DestroyPlayer()
    {
        if (readyToDestroy)
        {
            // spin & shrink player
            transform.Rotate(0, killRotation * Time.deltaTime, 0);
            transform.localScale -= new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);

            // destroy player when scale == 0
            if (Mathf.Min(transform.localScale.x, transform.localScale.y, transform.localScale.z) <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle" && playerHealth > 0)
        {
            playerHealth -= 1;
            Debug.Log("Health: " + playerHealth);
        }
    }

}
