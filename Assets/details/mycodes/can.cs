using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class can : MonoBehaviour
{
    public Image[] hearts;

    public int health = 4;
    public ParticleSystem obstackleParticle;
    //public ParticleSystem heartParticle;
    private bool dead;
    public GameObject gameOver;
    public AudioSource voicerrr;
    public AudioSource glassVoice;
    public float musicvolume;
    public GameObject pauseMenu;
    public void Start()
    {
        health = hearts.Length;

        glassVoice.Pause();


    }
    public void Update()
    {
        if (dead == true)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
          
            Invoke("gameover", 5f);
            voicerrr.Pause();


        }

        glassVoice.volume = musicvolume;


    }

    public void Damage(int amount)
    {
        hearts[health - 1].enabled = false;
        health -= amount;
        
        if (health == 0)
        {
           
            dead = true;
        }

       

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
       if (col.gameObject.tag == "obstackles")
       {
          
            Damage(1);
            musicvolume = 1;
            glassVoice.Play();
            Instantiate(obstackleParticle, transform.position, Quaternion.identity);

        }
        
       
   
       
    }
   
    
}
