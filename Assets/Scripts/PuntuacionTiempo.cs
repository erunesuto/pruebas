using UnityEngine;

public class PuntuacionTiempo : MonoBehaviour{

    public static int puntuacionTiempo = 0;
    //creamos una variable de tipo TextMesh(texto), esta variable la asociamos desde el inspector de la camara
    public TextMesh marcador;

    // Use this for initialization
    void Start()
    {
        //NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntosTiempo");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        ActualizarMarcador();
    }

    void PersonajeHaMuerto(Notification notificacion)
    {
        if (puntuacionTiempo > EstadoJuegoTiempo.estadoJuegoTiempo.puntuacionMaximaTiempo)
        {
            EstadoJuegoTiempo.estadoJuegoTiempo.puntuacionMaximaTiempo = puntuacionTiempo;
            EstadoJuegoTiempo.estadoJuegoTiempo.Guardar();
        }
    }

    void IncrementarPuntosTiempo(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacionTiempo += puntosAIncrementar;
        ActualizarMarcador();
    }
    //void ActualizarMarcadorTiempo()
    void ActualizarMarcador()
    {
        marcador.text = puntuacionTiempo.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
