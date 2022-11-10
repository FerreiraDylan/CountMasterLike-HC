using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_Units : MonoBehaviour
{
    public Generate_Units GU;
    public Text txt_units;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt_units.text = GU.value.ToString();
    }
}
