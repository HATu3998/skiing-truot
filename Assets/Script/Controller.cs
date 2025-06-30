using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float torque = 1;
    [SerializeField] Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boosts = 30f;
    [SerializeField] float nomalBoots = 15f;
    public Boolean check = true;
    // Vector3 originalScale;
    void Start()
    {
        //   originalScale = transform.localScale;
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            Rotate();
            BoostSpeed();
        }
    }
    public void CheckBool()
    {
        check = false;
    }
    void BoostSpeed()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boosts;
        }else
        {
            surfaceEffector2D.speed = nomalBoots;
        }
    }

    void Rotate()
    {
        if (rb == null)
        {
            Debug.LogError("Chưa gán Rigidbody2D cho Controller!");
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
            // transform.localScale = new Vector3(-Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
            // transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
    }
}
