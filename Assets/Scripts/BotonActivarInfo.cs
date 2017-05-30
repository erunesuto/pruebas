using UnityEngine;

public class BotonActivarInfo : MonoBehaviour
{

    public GameObject objeto;
    //nombre de la notificacion para modificar la variable de la animacion a cambiar true/false (ActivarMenuInfo)
    public string cargarInfo = "ActivarInformacion";
    bool activo = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        //detiene el audio de la camara y luego reproduce el del boton jugar
        //Camera.main.GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();

        objeto.SetActive(true);
        //El if es para evitar que salga una notificacion diciendo que no encuentra la notificacion
        if (activo==true)
        NotificationCenter.DefaultCenter().PostNotification(this, cargarInfo);
        //NotificationCenter.DefaultCenter().PostNotification(this, "cargarInfo");
        else activo = true;

    }

    
    
}
