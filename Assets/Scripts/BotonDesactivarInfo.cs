using UnityEngine;

public class BotonDesactivarInfo : MonoBehaviour {

    //nombre de la notificacion para modificar la variable de la animacion a cambiar true/false (ActivarMenuInfo)
    public string cargarInfo = "DesactivarInformacion";

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    { 
        //Camera.main.GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();
        //NotificationCenter.DefaultCenter().PostNotification(this,"DesactivarInformacion");
        NotificationCenter.DefaultCenter().PostNotification(this, cargarInfo);
    }
}
