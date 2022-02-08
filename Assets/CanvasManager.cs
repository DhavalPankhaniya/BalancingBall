using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Text lives;
    void Start()
    {   
        lives.text = GameManager.lives.ToString();
    }
}
