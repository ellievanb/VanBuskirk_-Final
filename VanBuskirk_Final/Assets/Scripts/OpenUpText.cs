using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUpText : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool disabled = false;

    private void Start()
    {
        objectToDisable.SetActive(true);
    }

    void OnMouseUp()
    {
        Debug.Log("Clicked!");
        StartCoroutine(Open());
    }


    IEnumerator Open()
    {

        objectToDisable.SetActive(false);

        yield return new WaitForSeconds(200);

        objectToDisable.SetActive(true);
    }
}
