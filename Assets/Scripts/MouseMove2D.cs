using UnityEngine;
using System.Collections;

public class MouseMove2D : MonoBehaviour
{

    private Vector3 mousePosition; 
    public float moveSpeed = 0.1f; //Hastigheten f�r verktygets r�relse - Adam

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
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //G�r s� att kameran f�ljer muspositionen - Adam
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed); //G�r s� att verktyget kan �ka runt med hj�lp av matematiska funktioner - Adam
        }

    }
}

