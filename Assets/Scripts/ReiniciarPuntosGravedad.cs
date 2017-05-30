using UnityEngine;

public class ReiniciarPuntosGravedad : MonoBehaviour {

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
        EstadoJuegoGravedad.estadoJuegoGravedad.puntuacionMaximaGravedad = 0;
    }
}
