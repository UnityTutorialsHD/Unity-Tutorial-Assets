using UnityEngine;
using System.Collections;

public class ShowGUI : MonoBehaviour {
    private bool showGUI = false;
     public Texture pressE;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        showGUI = true;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            showGUI = false;
    }


    void OnGUI()
    {
        if (showGUI == true)
            GUI.DrawTexture(new Rect(Screen.width / 1.5f, Screen.height / 1.4f, 178, 178), pressE);
    }
}
