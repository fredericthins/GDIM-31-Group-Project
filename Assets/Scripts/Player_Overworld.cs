using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Purpose: Player detection when encountering interactables (Death Zones, Goals, Enemies)
public class Player_Overworld : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player touches the red/death zones, remove player control and invoke the Game Manager game over event
        if (collision.CompareTag("Death"))
        {
            GameManager.OnGameOver();
            Destroy(gameObject);
        }

        //Currently, the detection is simple. It detects a specific goal tag and moves the player to the next level. However, in future implementations, the goal function will be more standardized
        if (collision.CompareTag("Goal1"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
