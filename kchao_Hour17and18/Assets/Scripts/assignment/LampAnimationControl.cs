using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAnimationControl : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //animator.Play("ChangePosition");
            animator.SetTrigger("Position");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //animator.Play("ChangeRotation");
            animator.SetTrigger("Rotation");
            Debug.Log('S');
        }
    }
}
