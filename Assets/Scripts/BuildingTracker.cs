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

    public TMP_Text houseTrk;

    void Update()
    {
        houses = GameObject.FindGameObjectsWithTag("House");

        int housenumber = houses.Length;

        houseTrk.text = "Houses: " + housenumber;

    }
}
