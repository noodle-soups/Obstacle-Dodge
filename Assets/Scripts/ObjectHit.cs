using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
    }

}
