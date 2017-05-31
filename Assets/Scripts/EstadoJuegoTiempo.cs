using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuegoTiempo : MonoBehaviour
{

    public int puntuacionMaximaTiempo = 0;

    public static EstadoJuegoTiempo estadoJuegoTiempo;

    private String rutaArchivoTiempo;

    void Awake()
    {
        //Debug.Log(Application.persistentDataPath);
        //ruta C:/Users/Ernesto/AppData/LocalLow/DefaultCompany/Proyecto Comares
        //Application.persistentDataPath es C:/Users/Ernesto/AppData/LocalLow/DefaultCompany/Proyecto Comares/Assets
        //Y datos.dat el archivo donde guardaremos la puntuacion
        //modificar /datosTiempo.dat por /datosTiempo.dat, guardar todas las puntuaciones en un solo archivo
        rutaArchivoTiempo = Application.persistentDataPath + "/datosTiempo.dat";
        //Si es la primera vez que el componente que tiene este script se esta ejecutando entra
        if (estadoJuegoTiempo == null)
        {
            //this hace referencia a la estancia del componente que esta ejecutando este codigo
            estadoJuegoTiempo = this;
            DontDestroyOnLoad(gameObject);
        }
        //si es distinto de la estancia actual se destruye
        else if (estadoJuegoTiempo != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        Cargar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivoTiempo);

        DatosAGuardar datos = new DatosAGuardar();
        datos.puntuacionMaxima = puntuacionMaximaTiempo;

        bf.Serialize(file, datos);

        file.Close();
    }

    void Cargar()
    {
        if (File.Exists(rutaArchivoTiempo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivoTiempo, FileMode.Open);

            //al deserializar nos desvuelve un objeto no un tipo concreto. Se hace el casting a la clase DatosAGuardar
            DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);

            puntuacionMaximaTiempo = datos.puntuacionMaxima;

            file.Close();
        }
        else
        {
            puntuacionMaximaTiempo = 0;
        }
    }
}
//Se usa DatosAGuardar en vez de DatosAGuardarTiempo (?)
/*[Serializable]
class DatosAGuardar
{
    public int puntuacionMaximaTiempo;
}*/