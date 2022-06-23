using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehavior : MonoBehaviour
{
    bool state;
    float speed = 0;
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == true) {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 1);
        }
    }

    public void Run(float s) {
        speed = s;
        state = true;
    }
    
}
