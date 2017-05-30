using UnityEngine;

public class BotonActivarInfoTiempo : MonoBehaviour

{

    public GameObject objeto;

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
        NotificationCenter.DefaultCenter().PostNotification(this, "ActivarInformacionTiempo");
    }



}
