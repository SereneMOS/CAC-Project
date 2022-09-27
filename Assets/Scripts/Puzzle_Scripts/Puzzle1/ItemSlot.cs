using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public int Startx;
    public int Starty;
    public int VisibleSlide;
    int SlideNumber = 0;
    bool Active = false;
    public int WhichPuzzle = 0;
    bool Clicked2 = false;

    void Start()
    {
        transform.position = new Vector3(-700, -700, 0);
    }

    public void GoAway()
    {
        transform.position = new Vector3(-700, -700, 0);
    }

    void Update()
    {
        if (WhichPuzzle == 4)
        {
            GameObject IsActive = GameObject.Find("Draggo");
            DrapAndDrop Connect = IsActive.GetComponent<DrapAndDrop>();
            bool Dropped = Connect.InDropSlot;
            Active = Dropped;
            if (Active == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }

        if (WhichPuzzle == 15)
        {
            GameObject IsActive = GameObject.Find("Drag_2");
            DrapAndDrop Answered3 = IsActive.GetComponent<DrapAndDrop>();
            bool Done3 = Answered3.InDropSlot;
            Clicked2 = Done3;
            if (Clicked2 == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }
    }

    public void Begin()
    {
        transform.position = new Vector3(Startx, Starty, 0);
    }
}
