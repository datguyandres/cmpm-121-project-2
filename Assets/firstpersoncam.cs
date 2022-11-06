using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstpersoncam : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y+4, target.transform.position.z);
        // Rotate the camera every frame so it keeps looking at the target
        //transform.LookAt(target);
    }
}