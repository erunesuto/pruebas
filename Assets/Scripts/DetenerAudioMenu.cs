using UnityEngine;

//NO SE USA

public class DetenerAudioMenu : MonoBehaviour {

    //public GameObject reproductorAudio;

    void Awake()
    {
        AudioMenu.audioMenu.GetComponent<AudioSource>().Stop();
        //reproductorAudio.SetActive(false);

    }

	// Use this for initialization
	void Start () {
        //reproductorAudio.SetActive(false);
        //GetComponent<AudioSource>().Stop();
        //AudioMenu.audioMenu.GetComponent<AudioSource>().Stop();
        //Destroy(AudioMenu.audioMenu);
        //camaraGameOver.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
