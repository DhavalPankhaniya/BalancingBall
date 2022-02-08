using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    private void Start() {
        PlayerData data = SaveSystem.loadLevel();
        GameManager.lives = data.lives;
        GameManager.score = data.score;
        GameManager.currentLevelIndex = data.currentLevelIndex;
        Debug.Log("Current Level Index: " + GameManager.currentLevelIndex);
    }
    public void startNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
