using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadControl : MonoBehaviour
{
    public Slider control;

    // Start is called before the first frame update
    void Start()
    {
        control.value = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //control.value = 0; 
        //GameManager.instance.controlAxis = control.value;
    }

    public void Test()
    {
        GameManager.instance.controlAxis = control.value;
    }
}
