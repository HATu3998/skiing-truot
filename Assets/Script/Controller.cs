using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float torque = 1;
    [SerializeField] Rigidbody2D rb;
   // Vector3 originalScale;
    void Start()
    {
     //   originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
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
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
           // transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
    }
}
