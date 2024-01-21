using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuildingMenu : MonoBehaviour
{
    public Button menuBtn;
    public GameObject buildingMenuPannel;

    public Button basicBtn;
    public GameObject basicSection;

    public Button shopBtn;
    public GameObject ShopSection;

    public Button lawBtn;
    public GameObject LawSection;

    public Button schoolBtn;
    public GameObject SchoolSection;

    public Button techBtn;
    public GameObject TechSection;

    public Button healthBtn;
    public GameObject HealthSection;

    public Button fireDptBtn;
    public GameObject FireDptSection;

    public bool active = false;
    public string section = "basic";









    void Start()
    {
        Button btn = menuBtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button basic = basicBtn.GetComponent<Button>();
        basic.onClick.AddListener(SectionBasic);

        Button shop = shopBtn.GetComponent<Button>();
        shop.onClick.AddListener(SectionShop);

        Button law = lawBtn.GetComponent<Button>();
        law.onClick.AddListener(SectionLaw);

        Button school = schoolBtn.GetComponent<Button>();
        school.onClick.AddListener(SectionSchool);

        Button tech = techBtn.GetComponent<Button>();
        tech.onClick.AddListener(SectionTech);

        Button health = healthBtn.GetComponent<Button>();
        health.onClick.AddListener(SectionHealth);

        Button fireDpt = fireDptBtn.GetComponent<Button>();
        fireDpt.onClick.AddListener(SectionFireDpt);

    }

    private void SectionFireDpt()
    {
        section = "firedpt";
        SectionOnClick(FireDptSection);
    }

    private void SectionHealth()
    {
        section = "health";
        SectionOnClick(HealthSection);
    }

    private void SectionTech()
    {
        section = "tech";
        SectionOnClick(TechSection);
    }

    private void SectionSchool()
    {
        section = "school";
        SectionOnClick(SchoolSection);
    }

    private void SectionLaw()
    {
        section = "law";
        SectionOnClick(LawSection);
    }

    private void SectionBasic()
    {
        section = "basic";
        SectionOnClick(basicSection);
    }
    private void SectionShop()
    {
        section = "shop";
        SectionOnClick(ShopSection);
    }

    private void SectionOnClick(GameObject Sectionthing)
    {
        basicSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);
        ShopSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);
        LawSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);
        SchoolSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);
        TechSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);
        HealthSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);
        FireDptSection.transform.position = new Vector3(Sectionthing.transform.position.x, 50, Sectionthing.transform.position.z);

        Sectionthing.transform.position += new Vector3(0, 120, 0);
    }

    void TaskOnClick()
    {
        if (active == false)
        {
            buildingMenuPannel.transform.position += new Vector3(0, 120, 0);
            menuBtn.transform.position += new Vector3(0, 120, 0);
            active = true;
            return;
        }

        if (active == true)
        {
            buildingMenuPannel.transform.position += new Vector3(0, -120, 0);
            menuBtn.transform.position += new Vector3(0, -120, 0);
            active = false;
            return;
        }
    }


}
