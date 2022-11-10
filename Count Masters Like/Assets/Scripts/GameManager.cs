using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public GameObject Menu;
    public GameObject Victory;
    public GameObject Defeated;
    public GameObject UI;

    public int mapLength;
    public int coinsAmount;
    public int diamsAmount;
    public int unitsAmount;
    public float moneyMultiplier;
    public int level;
    public int unitsLevel;
    public int moneyLevel;
    public int moneyUpPrice;
    public int unitsUpPrice;
    public int maxDistance;
    public int moneyEarned;
    public int unitsEarned;

    public bool startGame;
    public float controlAxis;

    // Start is called before the first frame update
    void Start()
    {
        GameAnalytics.Initialize();
        Screen.orientation = ScreenOrientation.Portrait;
        mapLength = PlayerPrefs.GetInt("mapLength", 20);
        maxDistance = (mapLength + 1) * 6;
        coinsAmount = PlayerPrefs.GetInt("coinsAmount", 0);
        diamsAmount = PlayerPrefs.GetInt("diamsAmount", 0);
        level = PlayerPrefs.GetInt("level", 0);
        unitsAmount = PlayerPrefs.GetInt("unitsAmount", 1);
        unitsLevel = PlayerPrefs.GetInt("unitsLevel", 1);
        moneyLevel = PlayerPrefs.GetInt("moneyLevel", 1);
        moneyUpPrice = PlayerPrefs.GetInt("moneyUpPrice", 15);
        unitsUpPrice = PlayerPrefs.GetInt("unitsUpPrice", 20);
        moneyMultiplier = PlayerPrefs.GetFloat("moneyMultiplier", 1.05f);
        GameAnalytics.SetCustomDimension01("Level");

        startGame = false;
        Menu.SetActive(true);
        Victory.SetActive(false);
        Defeated.SetActive(false);
        UI.SetActive(false);
        controlAxis = 0;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartGame()
    {
        Menu.SetActive(false);
        startGame = true;
        UI.SetActive(true);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("mapLength", mapLength);
        PlayerPrefs.SetInt("coinsAmount", coinsAmount);
        PlayerPrefs.SetInt("diamsAmount", diamsAmount);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("unitsAmount", unitsAmount);
        PlayerPrefs.SetInt("moneyUpPrice", moneyUpPrice);
        PlayerPrefs.SetInt("unitsUpPrice", unitsUpPrice);
        PlayerPrefs.SetInt("moneyLevel", moneyLevel);
        PlayerPrefs.SetInt("unitsLevel", unitsLevel);
        PlayerPrefs.SetFloat("moneyMultiplier", moneyMultiplier);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
