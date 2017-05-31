using UnityEngine;

public class ReiniciarPuntuacion : MonoBehaviour
{

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
        EstadoJuego.estadoJuego.puntuacionMaxima = 0;
    }
}
