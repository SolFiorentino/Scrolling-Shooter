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





    // Este método será llamado al presionar el botón Play
    public void PlayGame()
    {
        // Asegúrate de que el nombre del nivel es correcto según tus escenas
        SceneManager.LoadScene("Level 1");  
    
    }




}












