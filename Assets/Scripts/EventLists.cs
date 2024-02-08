using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventLists : MonoBehaviour
{
    public EventManager eventManager;
    public UiStatsBar uiStatsBar;
    public ObjectiveList objectiveList;
    public RelationshipManager relationshipchange;



    public GameObject eventBox;

    public Button eventButton;
    public GameObject eventButtonG;

    public bool testingFlag = false;

    public bool inFavorToQuest = false;
    public bool anotherWayToQuest = false;
    public bool opposedOfToQuest = false;

    public GameObject shopIMG;

    public Button inFavorButtion;
    public Button anotherWayButton;
    public Button opposedOfButtion;

    // Start is called before the first frame update
    void Start()
    {
        Button inFavor = inFavorButtion.GetComponent<Button>();
        inFavor.onClick.AddListener(InFavorButtonScript);
        Button anotherWay = anotherWayButton.GetComponent<Button>();
        anotherWayButton.onClick.AddListener(AnotherWayScript);
        Button opposedOf = opposedOfButtion.GetComponent<Button>();
        opposedOfButtion.onClick.AddListener(OpposedOfScript);
    }


    public void EventButtonClicked()
    {
        if (eventBox.activeInHierarchy == false)
            eventBox.SetActive(true);
        else
            eventBox.SetActive(false);
        eventManager.EventCall("Shop", shopIMG, "We need more Schools!", "There are more students than classrooms to teach them in!\nWon't you build more schools? ", "I'll build more schools!", "Let's cram students instead", "Can't do anything right now");
        eventButtonG.SetActive(false);
    }

    private void InFavorButtonScript()
    {
        inFavorToQuest = true;
    }
    private void AnotherWayScript()
    {
        anotherWayToQuest = true;
    }
    private void OpposedOfScript()
    {
        opposedOfToQuest = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((testingFlag == false) && (uiStatsBar.day == 1) && (uiStatsBar.time >= 30))
        {
            if (eventBox.activeInHierarchy == false)
            {
                eventButtonG.SetActive(true);
                uiStatsBar.TimeSpeedReset();
            }

            if (inFavorToQuest == true)
            {
                //objectiveList.buildMoreSchoolsQuest = true;
                inFavorToQuest = false;
                eventBox.SetActive(false);
                Destroy(eventManager.missionImage.gameObject);
                testingFlag = true;
            }
            if (anotherWayToQuest == true)
            {
                objectiveList.CrampedSchoolBuildingQuest = true;
                anotherWayToQuest = false;
                eventBox.SetActive(false);
                Destroy(eventManager.missionImage.gameObject);
                testingFlag = true;
            }
            if (opposedOfToQuest == true)
            {
                relationshipchange.schoolRelationshipUnits--;
                opposedOfToQuest = false;
                eventBox.SetActive(false);
                Destroy(eventManager.missionImage.gameObject);
                testingFlag = true;
            }
        }
    }








}