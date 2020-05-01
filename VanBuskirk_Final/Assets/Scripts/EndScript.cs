using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public void restartGame()
    {
        Debug.Log("Restart!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitGame()
    {
        Debug.Log("Exit!");
        Application.Quit();
    }
}
