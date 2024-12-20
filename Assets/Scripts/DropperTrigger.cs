using UnityEngine;

public class DropperTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Trigger");
            // change sibling's rb.useGravity = true
        }
    }

}
