using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Variables : MonoBehaviour
{
    public GameObject ParentSpawnUnit;

    // Start is called before the first frame update
    void Start()
    {
        var tmp = gameObject.transform;
        tmp.GetChild(4).GetComponent<Generate_Units>().UnitGroup = ParentSpawnUnit;
        tmp.GetChild(5).GetComponent<Generate_Units>().UnitGroup = ParentSpawnUnit;
    }
}
