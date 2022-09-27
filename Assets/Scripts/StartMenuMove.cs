using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuMove : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(960, 540, 0);
    }

    public void SceneBegin()
    {
        transform.position = new Vector3(-700, -700, 0);
    }
}
