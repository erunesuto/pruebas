using UnityEngine;

public class PuntuacionGravedad : MonoBehaviour { 

    public static int puntuacionGravedad = 0;
    //creamos una variable de tipo TextMesh(texto), esta variable la asociamos desde el inspector de la camara
    public TextMesh marcador;

    // Use this for initialization
    void Start()
    {
        //NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntosGravedad");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        ActualizarMarcador();
    }

    void PersonajeHaMuerto(Notification notificacion)
    {
        if (puntuacionGravedad > EstadoJuegoGravedad.estadoJuegoGravedad.puntuacionMaximaGravedad)
        {
            EstadoJuegoGravedad.estadoJuegoGravedad.puntuacionMaximaGravedad = puntuacionGravedad;
            EstadoJuegoGravedad.estadoJuegoGravedad.Guardar();
        }
    }

    void IncrementarPuntosGravedad(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacionGravedad += puntosAIncrementar;
        ActualizarMarcador();
    }
    //void ActualizarMarcadorTiempo()
    void ActualizarMarcador()
    {
        marcador.text = puntuacionGravedad.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}


		
	

