using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Mouse Y") * speed ;
        Debug.Log(movement);
        if(gameObject.transform.position.y >= 4 && movement >= 0){
            movement = 0;
        }
        if(gameObject.transform.position.y <= -4 && movement <= 0){
            movement = 0;
        }
        gameObject.transform.Translate(0 , movement , 0);
    }
}
