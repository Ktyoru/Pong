using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    //variable declaration
    public float speedx;
    public float speedy;
    public Text scoreboard;
    public float scorea;
    public float scoreb;
    void Start()
    {
        speedx = 0.10f;
        speedy = 0.10f;
        scorea = 0;
        scoreb = 0;
        scoreboard.text = $"{scorea} - {scoreb}";
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5 || transform.position.y < -5) {
            speedy *= -1;
        }
        else if (transform.position.x > 10) {
            transform.position = new Vector2(0, 0);
            speedx *= -1;
            scorea += 1;
            if (scorea == 7) {
                scorea = 0;
                scoreb = 0;
            }
            scoreboard.text = $"{scorea} - {scoreb}";
        }
        else if (transform.position.x < -10) {
            transform.position = new Vector2(0, 0);
            speedx *= -1;
            scoreb += 1;
            if (scoreb == 7) {
                scorea = 0;
                scoreb = 0;
            }
            scoreboard.text = $"{scorea} - {scoreb}";
        }
        transform.Translate(speedx, speedy, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        speedx *= -1;
    }
}
