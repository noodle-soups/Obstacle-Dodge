using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private Transform[] positions;
    private int currentIndexTarget = 0;

    private void Start()
    {

    }


    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // ensure we have positions to move between
        if (positions.Length == 0) return;

        // move towards _targetPosition
        Vector3 _targetPos = positions[currentIndexTarget].position;
        transform.position = Vector3.MoveTowards(transform.position, _targetPos, moveSpeed * Time.deltaTime);

        // check if _targetPos has been reached
        if (Vector3.Distance(transform.position, _targetPos) < 0.01f)
        {
            // update the index
            currentIndexTarget = (currentIndexTarget + 1) % positions.Length;
        }
    }

}
