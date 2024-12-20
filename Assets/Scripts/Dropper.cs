using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToDrop = 3;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToDrop)
        {
            Debug.Log("Drop!");
            rb.useGravity = true;
        }

    }
}
