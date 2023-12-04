using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine; 

public class RoadFixer : MonoBehaviour
{
    public GameObject deadEnd, roadStraight, corner, threeWay, fourWay;

    public void FixRoadAtPosition(PlacementManager placementManager, Vector3Int temporaryPosition)
    {
        var result = placementManager.GetNeighbourTypesFor(temporaryPosition);
        int roadCount = 0;
        roadCount = result.Where(x => x == CellType.Road).Count();
        if(roadCount == 0 || roadCount == 1)
        {
            CreateDeadEnd(placementManager, result, temporaryPosition);
        }
        else if(roadCount == 2)
        {
            if (CreateStraightRoad(placementManager, result, temporaryPosition))
                return;
            CreateCorner(placementManager, result, temporaryPosition);
        }
        else if (roadCount == 3)
        {
            Create3Way(placementManager, result, temporaryPosition);
        }
        else
        {
            Create4Way(placementManager, result, temporaryPosition);
        }
    }

    private void Create4Way(PlacementManager placementManager, CellType[] result, Vector3Int temporaryPosition)
    {
        placementManager.ModifyStructureModel(temporaryPosition, fourWay, Quaternion.Euler(-90, 0, 0));
    }

    private void Create3Way(PlacementManager placementManager, CellType[] result, Vector3Int temporaryPosition)
    {
        if (result[1] == CellType.Road && result[2] == CellType.Road && result[3] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, threeWay, Quaternion.Euler(-90, 0, 0));
        }else if (result[2] == CellType.Road && result[3] == CellType.Road && result[0] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, threeWay, Quaternion.Euler(-90, 90, 0));
        }
        else if (result[3] == CellType.Road && result[0] == CellType.Road && result[1] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, threeWay, Quaternion.Euler(-90, 180, 0));
        }
        else if (result[0] == CellType.Road && result[1] == CellType.Road && result[2] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, threeWay, Quaternion.Euler(-90, 270, 0));
        }
    }
    //Left Up Right Down
    private void CreateCorner(PlacementManager placementManager, CellType[] result, Vector3Int temporaryPosition)
    {
        if (result[1] == CellType.Road && result[2] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, corner, Quaternion.Euler(-90, 0, 0));
        }
        else if (result[2] == CellType.Road && result[3] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, corner, Quaternion.Euler(-90, 90, 0));
        }
        else if (result[3] == CellType.Road && result[0] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, corner, Quaternion.Euler(-90, 180, 0));
        }
        else if (result[0] == CellType.Road && result[1] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, corner, Quaternion.Euler(-90, 270, 0));
        }
    }

    private bool CreateStraightRoad(PlacementManager placementManager, CellType[] result, Vector3Int temporaryPosition)
    {
        if (result[0] == CellType.Road && result[2] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, roadStraight, Quaternion.Euler(-90, 90, 0));
            return true;
        }else if (result[1] == CellType.Road && result[3] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, roadStraight, Quaternion.Euler(-90, 180, 0));
            return true;
        }
        return false;
    }

    private void CreateDeadEnd(PlacementManager placementManager, CellType[] result, Vector3Int temporaryPosition)
    {
        if (result[1] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, deadEnd, Quaternion.Euler(-90, 180, 0));
        }
        else if (result[2] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, deadEnd, Quaternion.Euler(-90, 270, 0));
        }
        else if (result[3] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, deadEnd, Quaternion.Euler(-90, 0, 0));
        }
        else if (result[0] == CellType.Road)
        {
            placementManager.ModifyStructureModel(temporaryPosition, deadEnd, Quaternion.Euler(-90, 90, 0));
        }
    }
}
