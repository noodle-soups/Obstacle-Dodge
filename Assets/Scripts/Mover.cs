using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;
    [SerializeField] private float zSpeed;

    [SerializeField] private Transform[] positions;
    private int currentIndexTarget = 0;


    void Update()
    {

        if (positions.Length == 0) return;

        Vector3 targetPosition = positions[currentIndexTarget].position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, xSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            currentIndexTarget = (currentIndexTarget + 1) % positions.Length;
        }


    }

    private void HandleMovement()
    {
        //transform.position = Vector3.MoveTowards(transform.position, pos1, _xSpeed);
    }

}
