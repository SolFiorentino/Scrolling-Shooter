using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    // Este método será llamado al presionar el botón Play Again
    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}

