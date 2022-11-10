using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public GameObject Player;
    public GameObject End;

    public Image progressBar;
    public Text txt_Level;
    float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        maxDistance = GameManager.instance.maxDistance;
        progressBar.fillAmount = Player.transform.position.z / maxDistance;

    }

    // Update is called once per frame
    void Update()
    {
        if (progressBar.fillAmount < 1)
        {
            progressBar.fillAmount = Player.transform.position.z / maxDistance;
        }
    }
}
