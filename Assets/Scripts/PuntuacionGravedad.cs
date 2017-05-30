using UnityEngine;

public class PuntuacionGravedad : MonoBehaviour { 

    public static int puntuacionGravedad = 0;
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
        if (puntuacionGravedad > EstadoJuegoGravedad.estadoJuegoGravedad.puntuacionMaximaGravedad)
        {
            EstadoJuegoTiempo.estadoJuegoTiempo.puntuacionMaximaTiempo = puntuacionGravedad;
            EstadoJuegoTiempo.estadoJuegoTiempo.Guardar();
        }
    }

    void IncrementarPuntosTiempo(Notification notificacion)
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


		
	

