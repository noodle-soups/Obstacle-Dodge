using UnityEngine;

public class TestDropper : MonoBehaviour
{

    [SerializeField] GameObject dropperObstacle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enter drop zone");
            dropperObstacle.GetComponent<DropperMovement>().isTriggered = true;
        }
    }


}