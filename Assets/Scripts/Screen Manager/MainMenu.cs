using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    // Este m�todo ser� llamado al presionar el bot�n Play
    public void PlayGame()
    {
        // Aseg�rate de que el nombre del nivel es correcto seg�n tus escenas
        SceneManager.LoadScene("Level 1");  
    
    }




}












