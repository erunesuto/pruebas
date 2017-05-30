using UnityEngine;

public class ActualizarValoresGameOverTiempo : MonoBehaviour
{

    public TextMesh total;
    public TextMesh record;
    public PuntuacionTiempo puntuacionTiempo;

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
        total.text = PuntuacionTiempo.puntuacionTiempo.ToString();
        if (EstadoJuegoTiempo.estadoJuegoTiempo != null)
        {
            record.text = EstadoJuegoTiempo.estadoJuegoTiempo.puntuacionMaximaTiempo.ToString();
        }
    }
}