using UnityEngine;

public class DropperMovement : MonoBehaviour
{

    public bool isTriggered = false;
    [SerializeField] Transform dropZone;
    private Vector3 dropPos;
    [SerializeField] private float moveSpeed;

    void Start()
    {
        dropPos = dropZone.position;
    }

    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (isTriggered)
        {
            Debug.Log("Dropper triggered");
            transform.position = Vector3.MoveTowards(transform.position, dropPos, moveSpeed * Time.deltaTime);
        }
    }
}
