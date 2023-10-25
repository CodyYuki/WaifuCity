using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Entity : MonoBehaviour
{
    public string Name;
    public GameObject Menu;

    public Vector2 positionB;
    public Vector2 positionA;


    public bool ifClickedThisFrame = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseDown()
    {
        if (Name != null)
        {
            if (Name == "Building")
            {
                Menu.GetComponent<RectTransform>().anchoredPosition = positionB;
            }

            if (Name == "Something else")
            {
                Debug.Log("Something else");
            }
        }
        else
        {
            Debug.Log("Null Building");
        }

        ifClickedThisFrame = true;


    }

}
