using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public GameObject pausep;
    public GameObject gameoverP;

    public void buttton(string tıkla)
    {
       if (tıkla == "menu")
        {
            Application.LoadLevel(0);
            Time.timeScale = 1;
        }
        else if (tıkla == "tekrar")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;

        }

        else if (tıkla == "play")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
        else if (tıkla == "quit")
        {
            Application.Quit();
            
        }
    }
}
