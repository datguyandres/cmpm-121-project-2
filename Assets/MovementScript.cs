using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 3;
    void Update(){
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(x, 0, z);
    transform.Translate(movement * speed * Time.deltaTime);
    }
    //credit to gamedevbeginner.com for the movement input code
}
