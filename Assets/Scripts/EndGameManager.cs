using UnityEngine;

public class EndGameManager : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject endGameUI;

    private void Update()
    {
        if (player == null)
        {
            endGameUI.SetActive(true);
        }
    }

}
