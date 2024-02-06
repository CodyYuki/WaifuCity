using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveList : MonoBehaviour
{
    public UiStatsBar uiStatsBar;
    public float objectiveTime = 0;

    public bool CrampedSchoolBuildingQuest = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrampedSchoolBuildingQuest == true)
        {
            objectiveTime -= uiStatsBar.currentTimeSpeed;
            if (GameObject.Find("CrampedSchoolBuilding"))
            {
                ObjectiveCompleted();
            }
            if (objectiveTime <= 0)
            {
                ObjectiveFailed();
            }
        }




    }




    //for time 1440 is 24:00 so 24 hour time limit

    public void ObjectiveActivate(float timeLimit)
    {
        objectiveTime = timeLimit;
        
    }


    private void ObjectiveCompleted()
    {
        throw new NotImplementedException();
    }

    private void ObjectiveFailed()
    {
        throw new NotImplementedException();
    }
}
