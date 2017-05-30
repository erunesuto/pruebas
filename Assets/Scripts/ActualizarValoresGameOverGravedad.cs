using UnityEngine;

public class ActualizarValoresGameOverGravedad : MonoBehaviour
{

    public TextMesh total;
    public TextMesh record;
    public PuntuacionGravedad puntuacionGravedad;

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
        total.text = PuntuacionGravedad.puntuacionGravedad.ToString();
        if (EstadoJuegoGravedad.estadoJuegoGravedad != null)
        {
            record.text = EstadoJuegoGravedad.estadoJuegoGravedad.puntuacionMaximaGravedad.ToString();
        }
    }
}