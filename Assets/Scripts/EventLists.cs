using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLists : MonoBehaviour
{
    public EventManager eventManager;
    public UiStatsBar uiStatsBar;
    public ObjectiveList objectiveList;
    public bool Buttionyes;
    public bool testingFlag = false;

    public GameObject shopIMG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((testingFlag == false) && (uiStatsBar.day == 1) && (uiStatsBar.time >= 30))
        {
            uiStatsBar.TimeSpeedReset();
            eventManager.EventCall("Shop", shopIMG, "Testing", "Help help");

            if (Buttionyes == true)
            {
                objectiveList.CrampedSchoolBuildingQuest = true;
            }
            else
            {
                //somethign bad happens
            }
            testingFlag = true;
        }
    }
}
