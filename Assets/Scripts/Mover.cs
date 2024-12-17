using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float xValue = 0.01f;
    [SerializeField] float yValue = 0;
    [SerializeField] float zValue = 0;

    void Start()
    {
        Debug.Log("Game has started");
    }


    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
