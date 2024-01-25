using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiStatsBar : MonoBehaviour
{
    //1440 is 24:00

    public TMP_Text dayCount;
    public TMP_Text timeCount;
    public TMP_Text cashCount;
    public TMP_Text populationCount;

    public Button buttonSpeedx1, buttonSpeedx2, buttonSpeedx3;
    List<Button> buttonList;

    public float currentTimeSpeed = 0;

    public float day = 1;
    public float time = 0;
    public float cash = 0;
    public float population = 10;

    // Start is called before the first frame update
    void Start()
    {
        currentTimeSpeed = Time.deltaTime;

        buttonList = new List<Button> { buttonSpeedx1, buttonSpeedx2, buttonSpeedx3 };

        buttonSpeedx1.onClick.AddListener(() =>
        {
            currentTimeSpeed = Time.deltaTime;
        });

        buttonSpeedx2.onClick.AddListener(() =>
        {
            currentTimeSpeed = 0.2f;
        });

        buttonSpeedx3.onClick.AddListener(() =>
        {
            currentTimeSpeed = 0.8f;
        });
    }





    // Update is called once per frame
    void Update()
    {
        time += currentTimeSpeed;  //time is a float
        int seconds = ((int)time % 60);
        int minutes = ((int)time / 60);
        //Debug.Log(string.Format("{0:00}:{1:00}", minutes, seconds));
        timeCount.text = (string.Format("Time: " + "{0:00}:{1:00}", minutes, seconds));

    }



}
