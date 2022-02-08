using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float restartDelay = 1.5f;
    public Button continueGame;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public GameObject pauseMenu;
    public static int lives = 3;
    public static int currentLevelIndex = 1;
    public static int score = 10;

    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
        currentLevelIndex++;
        SaveSystem.saveLevel();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape))  pause();
    }
    public void EndGame()
    {
        SceneManager.LoadScene(1);
        // gameOverUI.SetActive(true);
        // Invoke("Restart", restartDelay);
    }
    public void Restart()
    {
        
    }

    public void pause() {
        pauseMenu.gameObject.SetActive(!pauseMenu.gameObject.activeSelf);
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
            CameraMovement.rotateAroundPlayer = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else {
            Time.timeScale = 1;
            CameraMovement.rotateAroundPlayer = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    private void Start() {
        // PlayerData data = SaveSystem.loadLevel();
        // lives = data.lives;
        // score = data.score;
        // Debug.Log("Lives: " + lives);
    }
}
