using UnityEngine;

public class Mover : MonoBehaviour
{



    void Start()
    {
        Debug.Log("Game has started");
    }


    void Update()
    {

        float _xValue = Input.GetAxisRaw("Horizontal");
        float _yValue = Input.GetAxisRaw("Vertical");
        float _zValue = 0;

        transform.Translate(_xValue, _yValue, _zValue);

        Debug.Log("_xValue: " + _xValue.ToString() + " | _yValue: " + _yValue.ToString());
    }
}
