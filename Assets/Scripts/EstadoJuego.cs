using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego : MonoBehaviour
{

    public int puntuacionMaxima = 0;

    public static EstadoJuego estadoJuego;

    private String rutaArchivo;

    //awake() se llama antes que start()
    void Awake()
    {
        //Debug.Log(Application.persistentDataPath);
        //ruta C:/Users/Ernesto/AppData/LocalLow/DefaultCompany/Proyecto Comares
        //Application.persistentDataPath es C:/Users/Ernesto/AppData/LocalLow/DefaultCompany/Proyecto Comares/Assets
        //Y datos.dat el archivo donde guardaremos la puntuacion
        rutaArchivo = Application.persistentDataPath + "/datos.dat";
        //Si es la primera vez que el componente que tiene este script se esta ejecutando entra
        if (estadoJuego == null)
        {
            //this hace referencia a la estancia del componente que esta ejecutando este codigo
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }
        //si es distinto de la estancia actual se destruye
        else if (estadoJuego != this)
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
        //creamos un archivo y le damos la ruta donde queremos que se guarde(rutaArchivo)
        FileStream file = File.Create(rutaArchivo);

        DatosAGuardar datos = new DatosAGuardar();
        datos.puntuacionMaxima = puntuacionMaxima;
        //se serializa y se vuelca la informacion en el archivo
        bf.Serialize(file, datos);

        file.Close();
    }

    void Cargar()
    {
        //comprobamos si existe el archivo para que no de error si no existe aun
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            //abrimos el archivo
            FileStream file = File.Open(rutaArchivo, FileMode.Open);

            //al deserializar nos desvuelve un objeto no un tipo concreto. Se hace el casting a la clase DatosAGuardar
            //se hace el casting para que trate al objeto como un objeto de esa clase
            DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);

            puntuacionMaxima = datos.puntuacionMaxima;

            file.Close();
        }
        else
        {
            puntuacionMaxima = 0;
        }
    }
}

[Serializable]
class DatosAGuardar
{
    public int puntuacionMaxima;
}