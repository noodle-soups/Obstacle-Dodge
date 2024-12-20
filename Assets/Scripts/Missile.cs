using Unity.VisualScripting;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPos;
    [SerializeField] float missileSpeed;

    void Start()
    {
        playerPos = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, missileSpeed * Time.deltaTime);
    }
}
