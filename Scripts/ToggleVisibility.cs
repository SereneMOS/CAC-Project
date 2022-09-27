using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisibility : MonoBehaviour
{
    public int inPlay;
    public bool isImgOn;
    public Image img;
    public int scoreAmount = 0;
    public bool IsSceneButton = false;

    void Start()
    {

        img.enabled = true;
        isImgOn = true;
    }

    void Update()
    {
        if (scoreAmount == inPlay)
        {
            img.enabled = true;
        }
        else
        {
            img.enabled = false;
        }
    }

    public void AddScore()
    {
        scoreAmount += 1;
        if (IsSceneButton == true && scoreAmount == inPlay)
        {
            transform.position = new Vector3(1200, 916, 0);
        }
    }
}
