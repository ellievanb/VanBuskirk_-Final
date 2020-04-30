using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public Canvas exitBackgroundImageCanvas;

    bool m_IsPLayerAtExit;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPLayerAtExit = true;
        }
    }

    void Update()
    {
        if(m_IsPLayerAtExit)
        {
            EndLevel();
        }
    }

    void EndLevel ()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvas.alpha = m_Timer / fadeDuration;
        if (m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
