using UnityEngine;

// SE ASIGNA A LAS CAMARAS QUE MUESTRAN INFORMACION HOW TO PLAY
public class ActivarMenuInfo : MonoBehaviour
{
    public Animator animator;
    public string nombreNotificacionActivar = "ActivarInformacion";
    public string nombreNotificacionDesactivar = "DesactivarInformacion";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //activar/desactivar info modo normal
        NotificationCenter.DefaultCenter().AddObserver(this, nombreNotificacionActivar);
        NotificationCenter.DefaultCenter().AddObserver(this, nombreNotificacionDesactivar);
        //activar/desactivar info modo por tiempo
        //NotificationCenter.DefaultCenter().AddObserver(this, "ActivarInformacionTiempo");
        //NotificationCenter.DefaultCenter().AddObserver(this, "DesactivarInformacionTiempo");


    }

    //FUNCIONES activar/desactivar info modo normal
    void ActivarInformacion(Notification notificacion)
    {
        animator.SetBool("ActivarInfo", true);  
    }

    void DesactivarInformacion(Notification notificacion)
    {
        animator.SetBool("ActivarInfo", false);
    }

    //FUNCIONES activar/desactivar info modo por tiempo
    void ActivarInformacionTiempo(Notification notificacion)
    {
        animator.SetBool("ActivarInfoTiempo", true);
    }

    void DesactivarInformacionTiempo(Notification notificacion)
    {
        animator.SetBool("ActivarInfoTiempo", false);
    }

    //FUNCIONES activar/desactivar info modo Gravedad
    void ActivarInformacionGravedad(Notification notificacion)
    {
        animator.SetBool("ActivarInfoGravedad", true);

    }

    void DesactivarInformacionGravedad(Notification notificacion)
    {
        animator.SetBool("ActivarInfoGravedad", false);
    }
}