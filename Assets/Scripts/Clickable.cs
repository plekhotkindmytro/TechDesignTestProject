using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public GameObject[] showOnClick;
    public GameObject[] hideOnClick;
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
                if (clickedObject.CompareTag(Constants.ClickableTag) && clickedObject.Equals(this.gameObject))
                {
                    if(showOnClick != null || showOnClick.Length > 0)
                    {
                        foreach (GameObject item in showOnClick)
                        {
                            item.SetActive(true);
                        }
                    }

                    if (hideOnClick != null || hideOnClick.Length > 0)
                    {
                        foreach (GameObject item in hideOnClick)
                        {
                            item.SetActive(false);
                        }
                    }

                    this.GetComponent<AudioSource>().Play();
                }
            }
        }

    }
}
