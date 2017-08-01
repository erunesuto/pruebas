using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour {

    private ControladorPJ controladorPJ;

	// Use this for initialization
	void Start () {
        controladorPJ = GetComponentInParent<ControladorPJ>();
	}


    private void OnCollisionStay2D(Collision2D collision)
    {
        controladorPJ.enSuelo = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        controladorPJ.enSuelo = false;
    }
}
