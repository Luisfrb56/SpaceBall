using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    public void play( )
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SpaceBall");

        }
    
    public void salir()
    {
        Application.Quit();
    }
}
