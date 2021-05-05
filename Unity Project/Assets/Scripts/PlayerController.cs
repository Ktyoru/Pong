using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //variable declaration
    float speed;
    float vInput;
    void Start()
    {
        speed = 0.25f;
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the player move
        if (gameObject.CompareTag("Player")) {
            vInput = Input.GetAxis("Alternative Vertical");
            
        } else if (gameObject.CompareTag("Player 2")) {
            vInput = Input.GetAxis("Vertical");
        }
        transform.Translate(0, vInput * speed, 0);
    }
    
}
