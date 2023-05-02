using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_menu : MonoBehaviour
{
    public KeyCode input_button;
    private bool isPressed = false;
    private GameObject menu;
    private bool big_press;
    



    void Start()
    {
        
        menu = GameObject.Find("Menu");
        if (menu == null)
        {
            Debug.Log("No se encontro el objeto");
        }
        else
        {
            if (menu.activeSelf)
            {
                menu.SetActive(false);
                
            }
            else
            {
                Debug.Log("Se encontro el objeto");
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKey(input_button))
        {
            big_press = true;
        }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        if (big_press && (Input.GetMouseButton(0) || Input.GetKey(input_button)) && hit.collider != null && hit.collider.gameObject == gameObject )
        {
            if (isPressed)
            {
                return;
            }

            isPressed = true;

            if (menu == null)
            {
                Start();
            }
            else
            {
                menu.SetActive(!menu.activeSelf);
            }
        }
        else
        {
            isPressed = false;
        }
    }
}