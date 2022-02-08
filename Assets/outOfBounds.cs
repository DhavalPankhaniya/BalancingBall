using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter() {
         if(GameManager.lives > 0) {
            gameManager.Restart();
        } else {
            gameManager.EndGame();
        }
    }

}
