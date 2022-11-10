using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMap : MonoBehaviour
{
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Generate Units in relation with value variable
    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
            transform.GetComponent<BoxCollider>().enabled = false;
            active = false;
            GameManager.instance.UI.SetActive(false);
            StartCoroutine(StopGame());
            StartCoroutine(DisplayUI());
            GameManager.instance.moneyEarned = GameManager.instance.unitsEarned + Mathf.RoundToInt(GameManager.instance.level * GameManager.instance.moneyMultiplier);
            GameManager.instance.coinsAmount += GameManager.instance.moneyEarned;
            GameManager.instance.level += 1;
            GameManager.instance.mapLength += 1;
        }
    }
    IEnumerator StopGame()
    {
        yield return new WaitForSeconds(1f);

        GameManager.instance.startGame = false;
    }

    IEnumerator DisplayUI()
    {
        yield return new WaitForSeconds(1f);

        GameManager.instance.Victory.SetActive(true);
    }
}
