using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public GameObject Unit;
    public GameObject UnitGroup;

    bool isTouching;
    float touchPosX;
    Vector3 direction;

    float horizontalInput;
    float horizontalMultiplier = 2f;

    float axisX = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i != GameManager.instance.unitsAmount; i++)
        {
            GameObject tmp = Instantiate(Unit, UnitGroup.transform.position, Quaternion.identity);
            tmp.transform.SetParent(UnitGroup.transform);
            tmp.GetComponent<UnitMovement>().target = UnitGroup.transform;
        }
    }

    private void FixedUpdate()
    {
        axisX = 0;
        if (GameManager.instance.startGame)
        {
            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
            Vector3 horizontalMove = transform.right * GameManager.instance.controlAxis * (speed / 2)  * Time.fixedDeltaTime * horizontalMultiplier;

            rb.MovePosition(rb.position + forwardMove + horizontalMove);
            //GameManager.instance.controlAxis = 0;
        }
    }
    void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //Debug.Log("[<>]= " + horizontalInput);
        if (UnitGroup.transform.childCount == 0)
        {
            GameManager.instance.startGame = false;
            GameManager.instance.UI.SetActive(false);   

            StartCoroutine(DisplayUI());
        }
        GameManager.instance.unitsEarned = UnitGroup.transform.childCount;
    }

    IEnumerator DisplayUI()
    {
        yield return new WaitForSeconds(1f);

        GameManager.instance.Defeated.SetActive(true);
    }
}
