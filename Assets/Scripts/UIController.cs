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

    public UiStatsBar uiStatsBar;

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
            if (uiStatsBar.cash >= 3000)
            {
                ResetButtonColor();
                ModifyOutline(placeHouseButton);
                OnHousePlacement?.Invoke();
            }
        });
        placePoliceButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placePoliceButton);
            OnPolicePlacement?.Invoke();

        });
        placeHealthButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHealthButton);
            OnHealthPlacement?.Invoke();

        });
        placeShopButton.onClick.AddListener(() =>
        {
            if (uiStatsBar.cash >= 2400)
            {
                ResetButtonColor();
                ModifyOutline(placeShopButton);
                OnShopPlacement?.Invoke();
            }

        });
        placeSchoolButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSchoolButton);
            OnSchoolPlacement?.Invoke();

        });
        placeTechButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeTechButton);
            OnTechPlacement?.Invoke();

        });
        placeFireDptButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeFireDptButton);
            OnFireDptPlacement?.Invoke();

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
