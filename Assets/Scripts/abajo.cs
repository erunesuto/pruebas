using UnityEngine;

public class abajo : MonoBehaviour {

    public int salto = 3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        Physics2D.gravity = new Vector2(0, -12);
        //NotificationCenter.DefaultCenter().PostNotification(this, "SaltoAbajo");
    }

}
