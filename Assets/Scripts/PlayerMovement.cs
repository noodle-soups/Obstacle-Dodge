using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private CharacterController characterController;
    [SerializeField] float moveSpeed = 10f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
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
        //transform.Translate(_move);
        characterController.Move(_move);
    }

}
