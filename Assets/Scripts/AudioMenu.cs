using UnityEngine;

//NO USADO

//comparte el objeto AudioMenu por todas las escenas. Se encarga de reproducir la musica del menu.

public class AudioMenu : MonoBehaviour {

    //bool control=true;
    //public AudioClip menuClip;
    public static AudioMenu audioMenu;
    //public GameObject reproductorAudio;

    void Awake()
    {
        Debug.Log("control awake1");
        GetComponent<AudioSource>().Play();

        if (audioMenu == null)
        {
            Debug.Log("control awake2");
            //this hace referencia a la estancia del componente que esta ejecutando este codigo
            audioMenu = this;
            DontDestroyOnLoad(gameObject);
        }
        //si es distinto de la estancia actual se destruye
        else if (audioMenu != this)
        {
            Debug.Log("control awake3");
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start() {
        //reproductorAudio.SetActive(true);
    

        //EstadoJuego.estadoJuego.GetComponent<AudioSource>().Play();
       // GetComponent<AudioSource>().Play();
        
        //GetComponent<AudioSource>().Play();
        //GetComponent<AudioSource>().clip = menuClip;
        //GetComponent<AudioSource>().loop = false;
        //GetComponent<AudioSource>().Play();
        Debug.Log("control start");

    }

    // Update is called once per frame
    void Update () {
        
        
    }
}
