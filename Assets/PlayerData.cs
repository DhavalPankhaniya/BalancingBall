using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int lives;
    public int score;
    public int currentLevelIndex;
    
    public PlayerData() {
        lives = GameManager.lives;
        score = GameManager.score;
        currentLevelIndex = GameManager.currentLevelIndex;
    }
}
