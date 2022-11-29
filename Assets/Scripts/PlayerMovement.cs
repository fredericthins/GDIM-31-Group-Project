using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Basic Player Movement
public class PlayerMovement : MonoBehaviour
{
    //Common Components for speed/movement. SerializeField in order to adjust in the inspector for better polish and flow
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpForce;
    float horizontalInput;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Get the rigidbody2d component from the Player GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Controls horizontal movement
        horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalInput * movementSpeed, rb.velocity.y);
        
        //Jump Implementation. In future implementation, there will be a grounded boolean in order to prevent multiple jumps in the air
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
