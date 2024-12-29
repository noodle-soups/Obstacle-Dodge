using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{

    // player
    [SerializeField] private GameObject player;

    // UI
    [SerializeField] private GameObject endGameUI;
    [SerializeField] private GameObject levelCompleteUI;

    // other
    [SerializeField] private GameObject levelCompleteTile;
    private LevelComplete levelCompleteScript;

    private void Start()
    {
        endGameUI.SetActive(false);
        levelCompleteScript = levelCompleteTile.GetComponent<LevelComplete>();
    }

    private void Update()
    {
        ActivateEndGameUI();
        ActivateLevelCompleteUI();
    }

    private void ActivateEndGameUI()
    {
        if (player == null)
        {
            endGameUI.SetActive(true);
        }
    }

    private void ActivateLevelCompleteUI()
    {
        if (levelCompleteScript.isLevelComplete)
        {
            levelCompleteUI.SetActive(true);
        }
    }

    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
