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

    public Button ShopBtn;
    public GameObject ShopSection;

    public Button LawBtn;
    public GameObject LawSection;

    public Button SchoolBtn;
    public GameObject SchoolSection;

    public Button TechBtn;
    public GameObject TechSection;

    public Button HealthBtn;
    public GameObject HealthSection;

    public Button FireDptBtn;
    public GameObject FireDptSection;

    public bool active = false;
    public string section = "basic";

    void Start()
    {
        Button btn = menuBtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button basic = basicBtn.GetComponent<Button>();
        basic.onClick.AddListener(SectionBasic);

        Button law = basicBtn.GetComponent<Button>();
        law.onClick.AddListener(SectionLaw);

        Button school = basicBtn.GetComponent<Button>();
        school.onClick.AddListener(SectionSchool);

        Button tech = basicBtn.GetComponent<Button>();
        tech.onClick.AddListener(SectionTect);

        Button health = basicBtn.GetComponent<Button>();
        health.onClick.AddListener(SectionHealth);

        Button fireDpt = basicBtn.GetComponent<Button>();
        fireDpt.onClick.AddListener(SectionFireDpt);

    }

    private void SectionFireDpt()
    {
        throw new NotImplementedException();
    }

    private void SectionHealth()
    {
        throw new NotImplementedException();
    }

    private void SectionTect()
    {
        throw new NotImplementedException();
    }

    private void SectionSchool()
    {
        throw new NotImplementedException();
    }

    private void SectionLaw()
    {
        section = "law";
    }

    private void SectionBasic()
    {
        section = "basic";
        SectionOnClick();
    }

    private void SectionOnClick()
    {
        throw new NotImplementedException();
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
