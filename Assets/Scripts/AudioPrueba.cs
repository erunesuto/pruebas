using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPrueba : MonoBehaviour
{
    public static AudioPrueba audioPrueba;
    static bool AudioBegin = true;
    
    void Awake()
    {
        if (audioPrueba == null)
        {
            //this hace referencia a la estancia del componente que esta ejecutando este codigo
            audioPrueba = this;
            DontDestroyOnLoad(gameObject);
        }
        //si es distinto de la estancia actual se destruye
        else if (audioPrueba != this)
        {
            Destroy(gameObject);
        }

       /* if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }*/
    }
    private void Start()
    {
        //asigna el nombre de la escena actual a una variable
        /*Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        Debug.Log(sceneName);*/
    }
    void Update()
    {
        //simplificar en funcion(?) consume mucha bateria (?)
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        //Debug.Log(sceneName);

        if (sceneName=="game scene" || sceneName == "game scene2" || sceneName == "game scene3")

        {
              GetComponent<AudioSource>().Stop();
              AudioBegin = false;
        }
        //
        if ((AudioBegin==false) && ((sceneName == "main scene") || (sceneName == "menu scene")  || (sceneName == "info menu")))
        {
            Debug.Log("dentro del if que reactiva el audio");
            GetComponent<AudioSource>().Play();
            AudioBegin = true;
        }
    }
}