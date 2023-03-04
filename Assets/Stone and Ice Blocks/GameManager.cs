using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool EndGame = false;
    private bool GamePaused = false;



    public GameObject WinScreen;
    public GameObject GameOverScreen;
    public GameObject PauseMenu;

    public void Awake() // Pour �viter les bugs �ventuels, je set le time du jeu normal avant d'appeler la fonction start
    {
        Time.timeScale = 1f;
    }


    public void Start()   //Hardcode la d�sactivation des �crans de victoire/d�faite pour etre sur qu'ils le soient  bien au d�marrage du jeu
    {

        PauseMenu.SetActive(false);
        WinScreen.SetActive(false);
        GameOverScreen.SetActive(false);


    }

    

    private void FixedUpdate()
    {
       
    }

    public void Victoire()
    {
        Time.timeScale = 0f;
        WinScreen.SetActive(true);

    }

    public void Pause()
    {

            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
  
    }



    public void GameOver()
    {
        
        

        if (!EndGame && !GamePaused)
        {
            GamePaused = true;
            EndGame = true;
            Time.timeScale = 0f;
            GameOverScreen.SetActive(true);
        }

        
    }

}
