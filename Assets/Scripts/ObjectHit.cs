using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    MeshRenderer mr;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Hit triggered");
            mr.material.color = Color.red;
        }
    }

}
