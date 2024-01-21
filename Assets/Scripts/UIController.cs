using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Action OnRoadPlacement, OnHousePlacement, OnPolicePlacement, OnShopPlacement, OnSchoolPlacement, OnTechPlacement, OnHealthPlacement, OnFireDptPlacement;
    public Button placeRoadButton, placeHouseButton, placePoliceButton, placeShopButton, placeSchoolButton, placeTechButton, placeHealthButton, placeFireDptButton;

    public Color outlineColor;
    List<Button> buttonList;

    private void Start()
    {
        buttonList = new List<Button> { placeRoadButton, placeHouseButton, placePoliceButton, placeShopButton, placeSchoolButton, placeTechButton, placeHealthButton, placeFireDptButton };

        placeRoadButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeRoadButton);
            OnRoadPlacement?.Invoke();

        });
        placeHouseButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHouseButton);
            OnHousePlacement?.Invoke();

        });
        placePoliceButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placePoliceButton);
            OnPolicePlacement?.Invoke();

        });

    }

    private void ModifyOutline(Button button)
    {
        var outline = button.GetComponent<Outline>();
        outline.effectColor = outlineColor;
        outline.enabled = true;
    }


    private void ResetButtonColor()
    {
        foreach (Button button in buttonList)
        {
            button.GetComponent<Outline>().enabled = false;
        }
    }

}
