using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    MeshRenderer mr;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mr.material.color = Color.red;
        }
    }

}
