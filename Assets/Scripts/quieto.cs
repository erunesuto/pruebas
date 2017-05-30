using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quieto : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }

    void OnMouseDown()
    {
        Physics2D.gravity = new Vector2(0, 0);
    }

}
