using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrapAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public int Startx;
    public int Starty;
    public int VisibleSlide;
    public bool InDropSlot = false;
    int SlideNumber = 0;
    bool Clicked2 = false;
    public int WhichPuzzle = 0;

    void Start ()
    {
        transform.position = new Vector3(-500, -500, 0);
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        if (InDropSlot == false) 
        {
            transform.position = Input.mousePosition;
        }
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        if (InDropSlot == false)
        {
            transform.position = new Vector3(Startx, Starty, 0);
        }
    }

    public void Begin()
    {
        transform.position = new Vector3(Startx, Starty, 0);
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        InDropSlot = true;
        transform.position = new Vector3(-500, -500, 0);
    }
    
    void Update()
    {
        if (WhichPuzzle == 15)
        {
            GameObject IsActive = GameObject.Find("Drag_2");
            DrapAndDrop Answered3 = IsActive.GetComponent<DrapAndDrop>();
            bool Done3 = Answered3.InDropSlot;
            Clicked2 = Done3;
            if (Clicked2 == true && InDropSlot == false)
            {
                transform.position = new Vector3(Startx, Starty, 0);
            }
        }
    }
}