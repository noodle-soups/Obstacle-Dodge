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

    // scenes
    private int currentSceneIndex;

    private void Start()
    {
        endGameUI.SetActive(false);
        levelCompleteUI.SetActive(false);

        levelCompleteScript = levelCompleteTile.GetComponent<LevelComplete>();

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
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
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(currentSceneIndex += 1);
    }

}
