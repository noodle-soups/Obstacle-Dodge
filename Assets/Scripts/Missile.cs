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
        MoveMissile();
        DestroyWhenReached();
    }

    private void MoveMissile()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, missileSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
