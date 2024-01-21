using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BuildingTracker : MonoBehaviour
{
    //GameObject houseTrk, shopTrk, healthTrk, schoolTrk, techTrk, lawTrk, fireDpt, constructionTrk;
    public GameObject[] houses;
    public GameObject[] shop;
    public GameObject[] health;
    public GameObject[] school;
    public GameObject[] tech;
    public GameObject[] law;
    public GameObject[] construction;

    public TMP_Text houseTrk;
    public TMP_Text shopTrk;
    public TMP_Text healthTrk;
    public TMP_Text schoolTrk;
    public TMP_Text techTrk;
    public TMP_Text lawTrk;
    public TMP_Text fireDpt;
    public TMP_Text constructionTrk;


    void Update()
    {
        houses = GameObject.FindGameObjectsWithTag("House");
        int housenumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("School");
        int schoolnumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("Shop");
        int shopnumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("Health");
        int healthnumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("Tech");
        int technumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("Law");
        int lawnumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("FireDpt");
        int firedptnumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        houses = GameObject.FindGameObjectsWithTag("Construction");
        int constructionnumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

    }
}
