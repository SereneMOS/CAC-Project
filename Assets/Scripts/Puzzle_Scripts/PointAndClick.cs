using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    public bool Correct = false;
    bool PuzzleInPlay = false;
    public int Startx;
    public int Starty;
    public int WhichPuzzle = 0;
    public bool Active = false;
    public bool Clicked2 = false;


    void Start()
    {
        Correct = false;
        PuzzleInPlay = false;
    }

    void Update()
    {
        if (WhichPuzzle == 4)
        {
            GameObject IsActive = GameObject.Find("Draggo");
            DrapAndDrop Connect = IsActive.GetComponent<DrapAndDrop>();
            bool Dropped = Connect.InDropSlot;
            Active = Dropped;
            if (Active == true && Correct == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
        }

        if (WhichPuzzle == 14)
        {
            GameObject IsActive = GameObject.Find("Button_Correct_4");
            PointAndClick Answered3 = IsActive.GetComponent<PointAndClick>();
            bool Done3 = Answered3.Correct;
            Clicked2 = Done3;
            if (Clicked2 == true && Correct == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
        }

        if (PuzzleInPlay == true)
        {
            transform.position = new Vector3(Startx, Starty, 0);
        }
    }

    public void RightAnswer()
    {
        Correct = true;
        PuzzleInPlay = false;
        transform.position = new Vector3(-500, -500, 0);
    }

    public void PuzzleStart()
    {
        PuzzleInPlay = true;
    }
}
