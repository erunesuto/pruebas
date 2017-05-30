using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Arriba : MonoBehaviour
{

    public int salto = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            Physics2D.gravity = new Vector2(0, 12);
        }
    
    }



    void OnMouseDown()
    {
        Physics2D.gravity = new Vector2(0, 10);
        //NotificationCenter.DefaultCenter().PostNotification(this, "SaltoArriba");
    }


}
