using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_PuzzleUI1 : MonoBehaviour
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
        if (WhichPuzzle == 11)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_1");
            PointAndClick Connect = IsActive.GetComponent<PointAndClick>();
            bool Dropped = Connect.Correct;
            Active = Dropped;
            if (Active == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        } 
        if (WhichPuzzle == 12)
        {
            GameObject IsActive = GameObject.Find("Drag_1");
            DrapAndDrop Answered = IsActive.GetComponent<DrapAndDrop>();
            bool Done = Answered.InDropSlot;
            Clicked = Done;
            if (Clicked == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }
        if (WhichPuzzle == 13)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_2");
            PointAndClick Answered = IsActive.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (Clicked == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }
        if (WhichPuzzle == 14)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_4");
            PointAndClick Answered = IsActive.GetComponent<PointAndClick>();
            bool Done = Answered.Correct;
            Clicked = Done;
            if (Clicked == true)
            {
                transform.position = new Vector3(-700, -700, 0);
            }
        }
        if (WhichPuzzle == 15)
        {
            GameObject IsActive = GameObject.Find("Drag_2");
            DrapAndDrop Answered = IsActive.GetComponent<DrapAndDrop>();
            bool Done = Answered.InDropSlot;
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
