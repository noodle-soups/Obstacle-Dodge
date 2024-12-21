using UnityEngine;

public class DropperTrigger : MonoBehaviour
{


    [SerializeField] GameObject obstacle;
    Rigidbody obstacleRb;

    private void Start()
    {
        obstacleRb = obstacle.GetComponent<Rigidbody>();
        obstacleRb.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Dropper triggered");
            obstacleRb.useGravity = true;
        }
    }

}
