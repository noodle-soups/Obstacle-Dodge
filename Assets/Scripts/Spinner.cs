using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xRotation;
    [SerializeField] float yRotation;
    [SerializeField] float zRotation;
    Vector3 rotationVector;

    void Update()
    {
        rotationVector = new Vector3(xRotation, yRotation, zRotation);
        transform.Rotate(rotationVector);
    }
}
