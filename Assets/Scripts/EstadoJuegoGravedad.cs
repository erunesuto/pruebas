using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuegoGravedad : MonoBehaviour
{

    public int puntuacionMaximaGravedad = 0;

    public static EstadoJuegoGravedad estadoJuegoGravedad;

    private String rutaArchivoGravedad;

    void Awake()
    {
        //Debug.Log(Application.persistentDataPath);
        //ruta C:/Users/Ernesto/AppData/LocalLow/DefaultCompany/Proyecto Comares
        //Application.persistentDataPath es C:/Users/Ernesto/AppData/LocalLow/DefaultCompany/Proyecto Comares/Assets
        //Y datos.dat el archivo donde guardaremos la puntuacion
        //modificar /datosTiempo.dat por /datosTiempo.dat, guardar todas las puntuaciones en un solo archivo
        rutaArchivoGravedad = Application.persistentDataPath + "/datosGravedad.dat";
        //Si es la primera vez que el componente que tiene este script se esta ejecutando entra
        if (estadoJuegoGravedad == null)
        {
            //this hace referencia a la estancia del componente que esta ejecutando este codigo
            estadoJuegoGravedad = this;
            DontDestroyOnLoad(gameObject);
        }
        //si es distinto de la estancia actual se destruye
        else if (estadoJuegoGravedad != this)
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
        FileStream file = File.Create(rutaArchivoGravedad);

        DatosAGuardar datosGravedad = new DatosAGuardar();
        datosGravedad.puntuacionMaxima = puntuacionMaximaGravedad;

        bf.Serialize(file, datosGravedad);

        file.Close();
    }

    void Cargar()
    {
        if (File.Exists(rutaArchivoGravedad))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivoGravedad, FileMode.Open);

            //al deserializar nos desvuelve un objeto no un tipo concreto. Se hace el casting a la clase DatosAGuardar
            DatosAGuardar datosGravedad = (DatosAGuardar)bf.Deserialize(file);

            puntuacionMaximaGravedad = datosGravedad.puntuacionMaxima;

            file.Close();
        }
        else
        {
            puntuacionMaximaGravedad = 0;
        }
    }
}
//Se usa DatosAGuardar en vez de DatosAGuardarTiempo (?)
/*[Serializable]
class DatosAGuardarGravedad
{
    public int puntuacionMaxima;
}*/
