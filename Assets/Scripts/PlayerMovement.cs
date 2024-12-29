using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Animator animator;
    private CharacterController characterController;

    [SerializeField] private float moveSpeed = 10f;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // raw inputs
        float _xValue = Input.GetAxis("Horizontal");
        float _zValue = Input.GetAxis("Vertical");

        // create _move vector
        Vector3 _move = new Vector3(_xValue, 0, _zValue);

        // normalize
        if (_move.magnitude > 1f)
        {
            _move.Normalize();
        }

        // apply speed
        _move *= moveSpeed * Time.deltaTime;

        // move player
        transform.Translate(_move);

        // animation
        animator.SetFloat("x Movement", _xValue);
        animator.SetFloat("z Movement", _zValue);
    }

}
