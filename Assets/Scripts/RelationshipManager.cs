using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelationshipManager : MonoBehaviour
{
    public GameObject shopIMG;
    public GameObject HeartPrefab;
    public Button relationshipButton;
    public float shopRelationshipUnits = 5;
    public float heartDistance;


    void Start()
    {
        Button btn = relationshipButton.GetComponent<Button>();
        btn.onClick.AddListener(RelationshipCheck);
    }


    // Update is called once per frame
    void Update()
    {


    }


    private void RelationshipCheck()
    {
        if (shopRelationshipUnits == 5)
        {
            SpawnHearts(1);
        }
    }


    public void SpawnHearts(int heart)
    {
        Instantiate(HeartPrefab, shopIMG.transform.parent);
        HeartPrefab.transform.position = new Vector3(100, 0, 0);
    }

}
