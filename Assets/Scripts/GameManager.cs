using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

//Purpose: Game Manager will invoke the game over state, transition between levels, and restart the game if needed. To be more specific, the game manager mainly manages game state.
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    [SerializeField] GameObject gameOverScreen;
    public static Action OnGameOver;

    //Singleton Implementation - Game Manager is univerisally used system. Also, there should be only one game manager in each scene. Therefore, the singleton implementation feels appropriate.
    // Start is called before the first frame update
    void Start()
    {
        if (_instance == null)
        {
            _instance = this;

            DontDestroyOnLoad(_instance);
        }
        else
        {
            if (_instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    //Allows other classes to call the Singleton
    public void GameOver()
    {
        OnGameOver.Invoke();
    }

    //Allows other classes to access the restart function. The restart will reload the first scene (Level one)
    public static void Restart()
    {
        SceneManager.LoadScene("World1_Test");
    }

    //Quit out of the game
    public static void Quit()
    {
        Application.Quit();
    }
}
