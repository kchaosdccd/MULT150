using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public float movementSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        //float xVal = Input.GetAxis("Mouse X");
        //float yVal = Input.GetAxis("Mouse Y");

        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        /*if (hVal != 0)
        {
            print("Horizontal movement selected: " + hVal);
        }
        if (vVal != 0)
        {
            print("Vertical movement selected: " + vVal);

        }*/
        transform.position = transform.position + new Vector3(hVal * movementSpeed * Time.deltaTime, vVal * movementSpeed * Time.deltaTime, 0);

        

        //transform.Translate(hVal, vVal, 0);

    }
}
