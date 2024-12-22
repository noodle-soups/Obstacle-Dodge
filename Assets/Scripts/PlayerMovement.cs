using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    private void Start()
    {

    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float _xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float _zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        Vector3 _move = new Vector3(_xValue, 0, _zValue);
        transform.Translate(_move);
    }

}
