using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingMenuHoverOverInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject BuildingInfo;
    public static float DistanceY = 180;

    public void OnPointerEnter(PointerEventData eventData)
    {
        BuildingInfo.transform.position = new Vector3(transform.position.x, DistanceY, transform.position.z);
        BuildingInfo.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        BuildingInfo.SetActive(false);
    }
}
