using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        PrintInstruction();
    }


    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Print something");
    }

    void MovePlayer()
    {
        float _xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float _zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(_xValue, 0, _zValue);
        //Debug.Log("_xValue: " + _xValue.ToString() + " | _zValue: " + _zValue.ToString());
    }


}
