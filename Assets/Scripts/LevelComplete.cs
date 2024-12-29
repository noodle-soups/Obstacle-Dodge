using UnityEngine;

public class LevelComplete : MonoBehaviour
{

    public bool isLevelComplete;
    [SerializeField] private GameObject player;
    private PlayerMovement playerMovementScript;

    private void Start()
    {
        isLevelComplete = false;
        playerMovementScript = player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Level Complete");
            isLevelComplete = true;
            playerMovementScript.enabled = false;
        }
    }

}
