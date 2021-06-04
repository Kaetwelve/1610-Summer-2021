using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptthree : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm abou to hit the ground!");
        }
    }
}
