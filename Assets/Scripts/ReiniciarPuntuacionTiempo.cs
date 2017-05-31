using UnityEngine;

public class ReiniciarPuntuacionTiempo : MonoBehaviour
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
        EstadoJuegoTiempo.estadoJuegoTiempo.puntuacionMaximaTiempo = 0;
    }
}
