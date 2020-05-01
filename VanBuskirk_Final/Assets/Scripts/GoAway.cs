using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAway : MonoBehaviour
{
    public GameObject disable;
    public static bool disabled = false;

    public void Away()
    {
        Debug.Log("GoAway!");
        disable.SetActive(true);
    }
}
