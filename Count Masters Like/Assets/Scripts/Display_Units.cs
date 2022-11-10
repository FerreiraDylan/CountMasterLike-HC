using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display_Units : MonoBehaviour
{
    public GameObject UnitsGroup;
    public Text txt_units;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt_units.text = UnitsGroup.transform.childCount.ToString();
    }
}
