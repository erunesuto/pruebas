using UnityEngine;

//Activa y desactiva el audio, activa/desactiva el AudioListener

public class BotonMute : MonoBehaviour {

    public GameObject barraOnOff;
    
    // Use this for initialization
    void Start () {
        if (AudioListener.pause == true)
            barraOnOff.SetActive(true);
        else
            barraOnOff.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        //Si no hay audio no hay barra
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            barraOnOff.SetActive(false);
        } else
        {
            AudioListener.pause = true;
            barraOnOff.SetActive(true);
        }
    }
}
