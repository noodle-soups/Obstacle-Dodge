using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject endGameUI;

    private void Start()
    {
        endGameUI.SetActive(false);
    }

    private void Update()
    {
        ActivateEngGameUI();
    }

    private void ActivateEngGameUI()
    {
        if (player == null)
        {
            endGameUI.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
