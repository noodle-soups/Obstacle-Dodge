using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToDrop = 3;
    MeshRenderer mr;
    Rigidbody rb;


    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mr.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToDrop)
        {
            Debug.Log("Drop!");
            rb.useGravity = true;
            mr.enabled = true;
        }

    }
}
