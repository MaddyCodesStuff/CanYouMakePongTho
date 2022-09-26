using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float ballXVelocity { get; set; }
    float ballYVelocity { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        ballXVelocity = .1f;
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.GetContact(0).normal);
        if(other.gameObject.tag == "paddle"){
            ballXVelocity *= -1;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(ballXVelocity,ballYVelocity,0);
    }
}
