using Mono.Reflection;
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
    public GameObject[] fireDpt;
    public GameObject[] construction;

    public TMP_Text houseTrk;
    public TMP_Text shopTrk;
    public TMP_Text healthTrk;
    public TMP_Text schoolTrk;
    public TMP_Text techTrk;
    public TMP_Text lawTrk;
    public TMP_Text fireDptTrk;
    public TMP_Text constructionTrk;


    void Update()
    {
        houses = GameObject.FindGameObjectsWithTag("House");
        int housenumber = houses.Length;
        houseTrk.text = "Houses: " + housenumber;

        school = GameObject.FindGameObjectsWithTag("School");
        int schoolnumber = school.Length;
        schoolTrk.text = "school: " + schoolnumber;

        shop = GameObject.FindGameObjectsWithTag("Shop");
        int shopnumber = shop.Length;
        shopTrk.text = "shop: " + shopnumber;

        health = GameObject.FindGameObjectsWithTag("Health");
        int healthnumber = health.Length;
        healthTrk.text = "health: " + healthnumber;

        tech = GameObject.FindGameObjectsWithTag("Tech");
        int technumber = tech.Length;
        techTrk.text = "tech: " + technumber;

        law = GameObject.FindGameObjectsWithTag("Law");
        int lawnumber = law.Length;
        lawTrk.text = "law: " + lawnumber;

        fireDpt = GameObject.FindGameObjectsWithTag("FireDpt");
        int firedptnumber = fireDpt.Length;
        fireDptTrk.text = "fireDpt: " + firedptnumber;

        construction = GameObject.FindGameObjectsWithTag("Construction");
        int constructionnumber = construction.Length;
        constructionTrk.text = "Houses: " + constructionnumber;

    }
}
