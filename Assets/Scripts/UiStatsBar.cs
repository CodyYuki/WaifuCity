using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiStatsBar : MonoBehaviour
{
    //1440 is 24:00


    public TMP_Text dayCount;
    public TMP_Text timeCount;
    public TMP_Text cashCount;
    public TMP_Text populationCount;

    public Button buttonSpeedx0, buttonSpeedx1, buttonSpeedx2, buttonSpeedx3;
    List<Button> buttonList;

    public float currentTimeSpeed = 0;

    public float day = 1;
    public float time = 0;
    public float cash = 0;
    public float population = 10;

    public GameObject[] houses;
    public GameObject[] shop;
    public GameObject[] health;
    public GameObject[] school;
    public GameObject[] tech;
    public GameObject[] law;
    public GameObject[] fireDpt;
    public GameObject[] construction;

    public int timeCashInterval = 0;
    // Start is called before the first frame update
    void Start()
    {
        TimeSpeedReset();
        timeCashInterval = 60;
        buttonList = new List<Button> { buttonSpeedx1, buttonSpeedx2, buttonSpeedx3 };

        buttonSpeedx0.onClick.AddListener(() =>
        {
            currentTimeSpeed = 0;
        });
        buttonSpeedx1.onClick.AddListener(() =>
        {
            currentTimeSpeed = 0.01f;
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
        houses = GameObject.FindGameObjectsWithTag("House");
        int housenumber = houses.Length;
       

        school = GameObject.FindGameObjectsWithTag("School");
        int schoolnumber = school.Length;
        

        shop = GameObject.FindGameObjectsWithTag("Shop");
        int shopnumber = shop.Length;
   

        health = GameObject.FindGameObjectsWithTag("Health");
        int healthnumber = health.Length;
        

        tech = GameObject.FindGameObjectsWithTag("Tech");
        int technumber = tech.Length;
   

        law = GameObject.FindGameObjectsWithTag("Law");
        int lawnumber = law.Length;


        fireDpt = GameObject.FindGameObjectsWithTag("FireDpt");
        int firedptnumber = fireDpt.Length;
        

        construction = GameObject.FindGameObjectsWithTag("Construction");
        int constructionnumber = construction.Length;
       





        time += currentTimeSpeed;  //time is a float
        int seconds = ((int)time % 60);
        int minutes = ((int)time / 60);
        //Debug.Log(string.Format("{0:00}:{1:00}", minutes, seconds));
       

        if (time >= 1440)
        {
            time = 0;
            day++;
        }


        if (shopnumber > 0)
        {
            cash += shopnumber * currentTimeSpeed * 0.1f;

        }




        timeCount.text = (string.Format("Time: " + "{0:00}:{1:00}", minutes, seconds));
        dayCount.text = (string.Format("Day: " + day));
        cashCount.text = (string.Format("Cash: " + "$"+ (int)cash));
    }


    public void TimeSpeedReset()
    {
        currentTimeSpeed = 0.01f;
    }

    

}
