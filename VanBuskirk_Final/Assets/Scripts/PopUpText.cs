using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool disabled = false;

    private void Start()
    {
        objectToDisable.SetActive(false);
    }

    void OnMouseUp()
    {
        Debug.Log("Clicked!");
        StartCoroutine(Open());
    }


    IEnumerator Open()
    {

        objectToDisable.SetActive(true);

        yield return new WaitForSeconds(3);

        objectToDisable.SetActive(false);
    }
}
