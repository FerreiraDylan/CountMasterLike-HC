using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu_Script : MonoBehaviour
{
    public Text txt_unitsLevel;
    public Text txt_unitsPrice;
    public Text txt_moneyLevel;
    public Text txt_moneyPrice;
    public Text txt_level;
    public Text txt_Coins;
    public Text txt_Diams;
    public Text txt_earnedMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt_level.text = "NIVEAU " + GameManager.instance.level.ToString();
        txt_unitsPrice.text = GameManager.instance.unitsUpPrice.ToString();
        txt_unitsLevel.text = GameManager.instance.unitsLevel.ToString() + "\nLVL";
        txt_moneyPrice.text = GameManager.instance.moneyUpPrice.ToString();
        txt_moneyLevel.text = GameManager.instance.moneyLevel.ToString() + "\nLVL";
        txt_earnedMoney.text = "+ " + GameManager.instance.moneyEarned.ToString();
        txt_Coins.text = GameManager.instance.coinsAmount.ToString();
        txt_Diams.text = GameManager.instance.diamsAmount.ToString();
    }

    public void Upgrademultiplier()
    {
        if (GameManager.instance.coinsAmount > GameManager.instance.moneyUpPrice)
        {
            GameManager.instance.coinsAmount -= GameManager.instance.moneyUpPrice;
            GameManager.instance.moneyMultiplier *= 1.05f;
            GameManager.instance.moneyLevel += 1;
            GameManager.instance.moneyUpPrice = Mathf.RoundToInt(GameManager.instance.moneyUpPrice * 1.5f);
        }
    }
    public void UpgradeUnits()
    {
        if (GameManager.instance.coinsAmount > GameManager.instance.unitsUpPrice)
        {
            GameManager.instance.coinsAmount -= GameManager.instance.unitsUpPrice;
            GameManager.instance.unitsAmount += 1;
            GameManager.instance.unitsLevel += 1;
            GameManager.instance.unitsUpPrice = Mathf.RoundToInt(GameManager.instance.unitsUpPrice * 1.5f);
        }
    }
}
