using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EventManager : MonoBehaviour
{
    public RelationshipManager relationshipManager;

    public GameObject missionImage;
    public TMP_Text eventTitle;
    public TMP_Text eventDescription;

    public TMP_Text inFavorText;
    public TMP_Text anotherWayText;
    public TMP_Text opposedToText;


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

    public void EventCall(string whoinvoled, GameObject waifuimage, string title, string description, string favorof, string anotherway, string opposedto)
    {
        Vector3 position = new Vector3(waifuimage.transform.position.x + 600, waifuimage.transform.position.y + 500, waifuimage.transform.position.z);
        missionImage = Instantiate(waifuimage, position, transform.rotation, transform.parent);
        eventTitle.text = string.Format(title);
        eventDescription.text = string.Format(description);
        inFavorText.text = string.Format(favorof);
        anotherWayText.text = string.Format(anotherway);
        opposedToText.text = string.Format(opposedto);
    }

}
