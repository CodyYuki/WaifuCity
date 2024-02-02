using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StructureManager : MonoBehaviour
{
    public StructurePrefabWeighted[] housesPrefabs, policePrefabs, hospitalPrefabs, fireDptPrefabs, techPrefabs, schoolPrefabs, shopPrefabs;
    public PlacementManager placementManager;
    public UiStatsBar uiStatsBar;
    private float[] houseWeights, policeWeights, hospitalWeights, fireDptWeights, techWeights, schoolWeights, shopWeights;
    public int housePrice = 0;
    public int ShopPrice = 0;
    public int SchoolPrice = 0;
    public int LawPrice = 0;
    public int HeathPrice = 0;
    public int FireDpt = 0;
    public int TechPrice = 0;


    private void Start()
    {
        houseWeights = housesPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        policeWeights = policePrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        hospitalWeights = hospitalPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        shopWeights = shopPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        techWeights = techPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        fireDptWeights = fireDptPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
        schoolWeights = schoolPrefabs.Select(prefabStats => prefabStats.weight).ToArray();
    }

    public void PlaceHouse(Vector3Int position)
    {
        if (uiStatsBar.cash >= housePrice)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(houseWeights);
                placementManager.PlaceObjectOnTheMap(position, housesPrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - housePrice;
            }
        }
    }

    public void PlacePolice(Vector3Int position)
    {
        if (uiStatsBar.cash >= LawPrice)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(policeWeights);
                placementManager.PlaceObjectOnTheMap(position, policePrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - LawPrice;
            }
        }
    }

    public void PlaceHospital(Vector3Int position)
    {
        if (uiStatsBar.cash >= HeathPrice)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(hospitalWeights);
                placementManager.PlaceObjectOnTheMap(position, hospitalPrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - HeathPrice;
            }
        }
    }

    public void PlaceShop(Vector3Int position)
    {
        if (uiStatsBar.cash >= ShopPrice)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(shopWeights);
                placementManager.PlaceObjectOnTheMap(position, shopPrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - ShopPrice;
            }
        }
    }

    public void PlaceSchool(Vector3Int position)
    {
        if (uiStatsBar.cash >= SchoolPrice)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(schoolWeights);
                placementManager.PlaceObjectOnTheMap(position, schoolPrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - SchoolPrice;
            }
        }
    }

    public void PlaceTech(Vector3Int position)
    {
        if (uiStatsBar.cash >= TechPrice)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(techWeights);
                placementManager.PlaceObjectOnTheMap(position, techPrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - TechPrice;
            }
        }
    }

    public void FireDptHospital(Vector3Int position)
    {
        if (uiStatsBar.cash >= FireDpt)
        {
            
            if (CheckPositionBeforePlacement(position))
            {
                int randomIndex = GetRandomWeightedIndex(fireDptWeights);
                placementManager.PlaceObjectOnTheMap(position, fireDptPrefabs[randomIndex].prefab, CellType.Structure);
                uiStatsBar.cash = uiStatsBar.cash - FireDpt;
            }
        }
    }


    private int GetRandomWeightedIndex(float[] weights)
    {
        float sum = 0f;
        for (int i = 0; i < weights.Length; i++)
        {
            sum += weights[i];
        }

        float randomValue = UnityEngine.Random.Range(0, sum);
        float tempSum = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if(randomValue >= tempSum && randomValue < tempSum + weights[i])
            {
                return i;
            }
            tempSum += weights[i];
        }
        return 0;
    }

    private bool CheckPositionBeforePlacement(Vector3Int position)
    {
        if(placementManager.CheckIfPositionInBound(position) == false)
        {
            Debug.Log("This Position is out of bounds");
            return false;
        }
        if (placementManager.CheckIfPositionIsFree(position) == false)
        {
            Debug.Log("This Position is not EMPTY");
            return false;
        }
        if(placementManager.GetNeighboursOfTypeFor(position,CellType.Road).Count <= 0)
        {
            Debug.Log("Must be placed near a road");
            return false;
        }
        return true;
    }
}

[Serializable]
public struct StructurePrefabWeighted
{
    public GameObject prefab;
    [Range(0,1)]
    public float weight;
}
