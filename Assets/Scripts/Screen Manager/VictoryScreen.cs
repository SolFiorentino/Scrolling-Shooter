using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    // Este m�todo ser� llamado al presionar el bot�n Play Again
    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}

