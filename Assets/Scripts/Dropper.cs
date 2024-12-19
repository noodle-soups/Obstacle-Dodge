using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float dropTime = 3;

    void Update()
    {
        if (Time.time > dropTime)
        {
            Debug.Log("Drop!");
        }

    }
}
