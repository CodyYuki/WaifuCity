using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{


    void Update()
    {
        Vector3 inputDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) inputDir.z = +1f;
        if (Input.GetKey(KeyCode.S)) inputDir.z = -1f;
        if (Input.GetKey(KeyCode.A)) inputDir.x = -1f;
        if (Input.GetKey(KeyCode.D)) inputDir.x = +1f;


        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x;

        float moveSpeed = 20f;
        transform.position += inputDir * moveSpeed * Time.deltaTime;



        float rotateDir = 0f;
        if (Input.GetKeyDown(KeyCode.Q)) rotateDir = +90f;
        if (Input.GetKeyDown(KeyCode.E)) rotateDir = -90f;

        transform.eulerAngles += new Vector3(0, rotateDir, 0);
    }

}
