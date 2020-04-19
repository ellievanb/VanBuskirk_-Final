using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBin : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked!");
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}
