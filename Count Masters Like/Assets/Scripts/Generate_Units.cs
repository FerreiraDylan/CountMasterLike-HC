using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Units : MonoBehaviour
{
    public GameObject UnitGroup;
    public GameObject Unit;
    public int value;

    public bool active = true;
    public GameObject otherwall;

    // Start is called before the first frame update
    void Start()
    {
        value = Random.Range(10, 25);
    }

    // Generate Units in relation with value variable
    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            transform.GetComponent<BoxCollider>().enabled = false;
            otherwall.GetComponent<Generate_Units>().active = false;
            active = false;

            for (int i = 0; i != value; i++)
            {
                GameObject tmp = Instantiate(Unit, UnitGroup.transform.position, Quaternion.identity);
                tmp.transform.SetParent(UnitGroup.transform);
                tmp.GetComponent<UnitMovement>().target = UnitGroup.transform;
            }
            Destroy(gameObject);
        }
    }
}
