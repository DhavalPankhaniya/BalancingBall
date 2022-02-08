using UnityEngine.SceneManagement;
using UnityEngine;
public class pause : MonoBehaviour
{
    public GameManager gameManager;
   public void continueGame() {
       gameManager.pause();
   }

    public void mainMenu() {
        SceneManager.LoadScene(0);
    }

    public void exit() {
        gameManager.EndGame();
    }
}
