using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleUI : MonoBehaviour
{
    public int Startx;
    public int Starty;
    public int VisibleSlide;
    int SlideNumber = 0;
    public bool Active = false;
    public int WhichPuzzle;
    public bool Clicked = false;
    

    void Start()
    {
        transform.position = new Vector3(-700, -700, 0);
    }

    public void Update()
    {
        if (WhichPuzzle == 1)
        {
            GameObject IsActive = GameObject.Find("Draggie");
            DrapAndDrop Connect = IsActive.GetComponent<DrapAndDrop>();
            bool Dropped = Connect.InDropSlot;
            Active = Dropped;
            if (Active == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        } 
        if (WhichPuzzle == 2)
        {
            GameObject IsActive = GameObject.Find("Button_Correct");
            PointAndClick Answered = IsActive.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (Clicked == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }
        if (WhichPuzzle == 3)
        {
            GameObject IsActive = GameObject.Find("Button_Correcto");
            PointAndClick Answered = IsActive.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (Clicked == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }
        if (WhichPuzzle == 4)
        {
            GameObject IsActive = GameObject.Find("Button_Correcte");
            PointAndClick Answered = IsActive.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (Clicked == true)
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
