using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public GameObject target;
    private Vector3 point;


    void Start()
    {
        point = target.transform.position;
        transform.LookAt(point);
    }






    void Update()
    {
        
        if (transform.position.x >= 20f)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -20f)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }


        if (transform.position.z >= 20f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20);
        }
        if (transform.position.z <= -20f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -20);
        }


        if (transform.position.y != 10)
        {
            transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        }






        Vector3 inputDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) inputDir.z = +1f;
        if (Input.GetKey(KeyCode.S)) inputDir.z = -1f;
        if (Input.GetKey(KeyCode.A)) inputDir.x = -1f;
        if (Input.GetKey(KeyCode.D)) inputDir.x = +1f;


        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x;

        float moveSpeed = 20f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;


        //float rotateDir = 0f;
        //if (Input.GetKeyDown(KeyCode.Q))
        //{ 
        //    rotateDir = +45f;
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    rotateDir = -45f;
        //}

        //transform.eulerAngles += new Vector3(0, rotateDir, 0);





        float rotateDir = 0f;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotateDir = +45f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rotateDir = -45f;
        }


        transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), rotateDir);


    }

}
