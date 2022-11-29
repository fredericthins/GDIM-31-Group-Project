using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Basic Camera Movement
public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //If the player is alive, the camera will follow them. The offset variable is to prevent layer/2D issue.
        if (player)
        {
            transform.position = player.position + offset;
        }
    }
}
