using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Animator animator;
    private CharacterController characterController;

    // movement
    [SerializeField] private float moveSpeed;
    [SerializeField] private float dashSpeed;
    private float xInput;
    private float yInput;
    private Vector3 moveInput;
    private Vector3 movePlayer;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleInputs();
        HandleDash();
        MovePlayer();
    }

    void HandleInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        moveInput = new Vector3(xInput, 0, yInput);

        if (moveInput.magnitude > 1f)
        {
            moveInput.Normalize();
        }

        movePlayer = moveInput * moveSpeed * Time.deltaTime;
    }

    void MovePlayer()
    {
        // move player
        transform.Translate(movePlayer);

        // animation
        animator.SetFloat("x Movement", xInput);
        animator.SetFloat("z Movement", yInput);
    }

    void HandleDash()
    {
        Vector3 _dashDirection;

        if (moveInput == Vector3.zero)
        {
            Debug.Log("ZERO");
            _dashDirection = new Vector3(0, 0, 1);
        }
        else
        {
            _dashDirection = moveInput;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Dash");
            transform.Translate(_dashDirection * dashSpeed);
        }
    }

}
