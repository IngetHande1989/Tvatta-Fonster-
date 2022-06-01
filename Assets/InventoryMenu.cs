using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    [SerializeField]
    Transform openButton;

    [SerializeField]
    Transform closeButton;

    [SerializeField]
    Transform toolMenu;

    [SerializeField]
    bool toolMenuActive = false;

    void Start()
    {

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!toolMenuActive)
            {
                toolMenuActive = true;
                openButton.gameObject.SetActive(false);
                closeButton.gameObject.SetActive(true);
                toolMenu.gameObject.SetActive(true);
            }
            else
            {
                toolMenuActive = false;
                openButton.gameObject.SetActive(true);
                closeButton.gameObject.SetActive(false);
                toolMenu.gameObject.SetActive(false);
            }
            
        }

        /*if(Input.GetKeyDown(KeyCode.Tab) && toolMenuActive)
        {
            toolMenuActive = false;
            openButton.gameObject.SetActive(true);
            closeButton.gameObject.SetActive(false);
            toolMenu.gameObject.SetActive(false);
        }*/
    }
}
