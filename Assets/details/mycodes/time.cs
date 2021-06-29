using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public static float zaman;
    public Text zamanText;
    public Text highScore;
    public int high_score;
    void Start()
    {
        zaman = 0;
        if (zaman == 0)
        {
             Time.timeScale = 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        high_score = (int)zaman;
        zamanText.text =  high_score.ToString();

        if (PlayerPrefs.GetInt("score")<= high_score)
        {
            PlayerPrefs.SetInt("score", high_score);
        }

        highScore.text = "high score :" + PlayerPrefs.GetInt("score").ToString();

    }

   
}
