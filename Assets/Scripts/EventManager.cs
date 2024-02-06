using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class EventManager : MonoBehaviour
{
    public RelationshipManager relationshipManager;
    
    
    public TMP_Text eventTitle;
    public TMP_Text eventDescription;

    public string currentinvolvement;
    


    //Note for Monday's CodyYuki to deal with:
    //events will be scripted as so:
    //when day and time is this, play this event,
    //if player needs to do something to play an event
    //such as making a jail and and event to upgrade it or something should come after
    //then check by making a flag of the building exisiting which then checked the flag being true
    //and the time being at the correct time.
    //failing to view the event will punish by losing 2 autos automaticly
    //after event is shown if the event leads to a objective then have a future script that creates one
    //if the event is just a small boost in something, then have the script ready to change the values of 
    //the relationship heart thing

    public void EventCall(string whoinvoled, GameObject waifuimage, string title, string description)
    {
        currentinvolvement = whoinvoled;
        Instantiate(waifuimage, transform.position, transform.rotation);
        eventTitle.text = string.Format(title);
        eventDescription.text = string.Format(description);
    }

}
