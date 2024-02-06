using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelationshipManager : MonoBehaviour
{
    public GameObject shopIMG;
    public GameObject schoolIMG;
    public GameObject lawIMG;
    public GameObject healthIMG;
    public GameObject firedptIMG;
    public GameObject techIMG;

    public GameObject relationshipFolder;

    List<GameObject> heartslist = new List<GameObject>();
    public GameObject HeartPrefab;
    public Button relationshipButton;

    public int shopRelationshipUnits = 5;
    public int schoolRelationshipUnits = 5;
    public int lawRelationshipUnits = 5;
    public int healthRelationshipUnits = 5;
    public int firedptRelationshipUnits = 5;
    public int techRelationshipUnits = 5;

    public bool state = false;

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
        //if (shopRelationshipUnits == 1)
        //{
        //    SpawnHearts(1);
        //}
        //if (shopRelationshipUnits == 2)
        //{
        //    SpawnHearts(2);
        //}
        //if (shopRelationshipUnits == 3)
        //{
        //    SpawnHearts(3);
        //}
        //if (shopRelationshipUnits == 4)
        //{
        //    SpawnHearts(4);
        //}
        //if (shopRelationshipUnits == 5)
        //{
        //    SpawnHearts(5);
        //}
        if (state == false)
        {
            SpawnHearts(shopRelationshipUnits, shopIMG);
            SpawnHearts(schoolRelationshipUnits, schoolIMG);
            SpawnHearts(lawRelationshipUnits, lawIMG);
            SpawnHearts(healthRelationshipUnits, healthIMG);
            SpawnHearts(firedptRelationshipUnits, firedptIMG);
            SpawnHearts(techRelationshipUnits, techIMG);

            relationshipFolder.transform.position += new Vector3(0, 900, 0);

            state = true;
        }
        else
        {
            relationshipFolder.transform.position -= new Vector3(0, 900, 0);
            for (int i = 0; i < heartslist.Count; i++)
            {
                Destroy(heartslist[i].gameObject);
            }
            state = false;
        }


    }


    public void SpawnHearts(int department, GameObject spawnIMG)
    {
        int distance = 100;
        for (int i = 0; i < department; i++)
        {
            Vector3 position = new Vector3(spawnIMG.transform.position.x + distance, spawnIMG.transform.position.y, spawnIMG.transform.position.z);
            GameObject instantheart = Instantiate(HeartPrefab, position, transform.rotation, spawnIMG.transform.parent);
            distance += 80;
            heartslist.Add(instantheart);
        }
    }

}
