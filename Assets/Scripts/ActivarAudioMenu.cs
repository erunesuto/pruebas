using UnityEngine;

//NO USADO

public class ActivarAudioMenu : MonoBehaviour {
    public GameObject reproductorAudio;

    void Awake()
    {
        //AudioMenu.audioMenu.GetComponent<AudioSource>().Play();
        //reproductorAudio.SetActive(true);

    }

	// Use this for initialization
	void Start () {
        //reproductorAudio.SetActive(true);
        Camera.main.GetComponent<AudioSource>().Stop();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
