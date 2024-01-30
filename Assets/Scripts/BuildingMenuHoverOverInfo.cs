using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingMenuHoverOverInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject BuildingInfo;
    public float DistanceY = 70;

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
