using UnityEngine.SceneManagement;
using UnityEngine;

public class loadNextLevel : MonoBehaviour
{
    public void nextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameManager.currentLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }
}
