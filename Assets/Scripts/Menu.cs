using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Menu Controller - Menu Subscriptions to Actions. Enabling and Disabling the menu when needed.
public class Menu : MonoBehaviour
{
    [SerializeField] GameObject Display;

    //Subscribes to the GameOver event in the game manager singleton. When an Game Over is invoked, the menu script will open the game over menu.
    public void Awake()
    {
        GameManager.OnGameOver += Open;
    }

    //Unsubscribes to the GameOver event in the game manager singleton. Prevents errors and issues.
    public void OnDestroy()
    {
        GameManager.OnGameOver -= Open;
    }

    //Enables the Game Over Menu
    private void Open()
    {
        Display.SetActive(true);
    }

}
