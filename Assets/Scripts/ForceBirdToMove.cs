using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class ForceBirdToMove : MonoBehaviour
{
    public GameObject arrowPointer;
    private Camera cam;
    void Start()
    {
        cam = Camera.main;  
    }

    void Update()
    {
        // I used Input Manager instead of Input System
        bool clicked = Input.GetMouseButtonDown(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began);
        if (clicked)
        {
            RaycastHit2D hit2D = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit2D.collider)
            {
                GameObject clickedObject = hit2D.collider.gameObject;
                if (clickedObject.CompareTag(Constants.BirdTag) && clickedObject.Equals(this.gameObject))
                {
                    clickedObject.GetComponent<Animator>().enabled = true;
                    this.GetComponent<ForceBirdToMove>().enabled = false;
                    if(arrowPointer != null)
                    {
                        arrowPointer.SetActive(false);
                        this.GetComponent<AudioSource>().Play();
                    }
                    
                }
            }
        }
        
    }
}
