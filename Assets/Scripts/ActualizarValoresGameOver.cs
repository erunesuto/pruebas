using UnityEngine;

public class ActualizarValoresGameOver : MonoBehaviour
{

    public TextMesh total;
    public TextMesh record;
    public Puntuacion puntuacion;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //se llama a la funcion cuando se activa el objeto
    void OnEnable()
    {
        total.text = Puntuacion.puntuacion.ToString();
        if (EstadoJuego.estadoJuego != null)
        {
            record.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString();
        }
    }
}