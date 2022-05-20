using UnityEngine;
using System.Collections;

public class MouseMove2D : MonoBehaviour
{

    private Vector3 mousePosition; 
    public float moveSpeed = 0.1f; //Hastigheten för verktygets rörelse - Adam

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            mousePosition = Input.mousePosition; 
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //Gör så att kameran följer muspositionen - Adam
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed); //Gör så att verktyget kan åka runt med hjälp av matematiska funktioner - Adam
        }

    }
}

