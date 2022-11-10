using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    bool isTouching;
    float touchPosX;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        
    }


    void GetInput()
    {
        if (Input.GetMouseButton(0)) {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
}
