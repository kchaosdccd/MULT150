using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class CameraControl : MonoBehaviour
{
    public GameObject camera;
    private float movementSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xVal = Input.GetAxis("Mouse X");
        float yVal = Input.GetAxis("Mouse Y");

        camera.transform.position = camera.transform.position + new Vector3(xVal * movementSpeed * Time.deltaTime, yVal * movementSpeed * Time.deltaTime, 0); 

       // camera.transform.Translate(xVal, 0f, 0f);
       // camera.transform.Translate(.05f, yVal, 0f);
    }
}
