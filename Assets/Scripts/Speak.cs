using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speak : MonoBehaviour {
    public GameObject player;
    public GameObject textCanvas;
    public string text;


    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        textCanvas = GameObject.FindWithTag("CanvasText");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided!!");
            textCanvas.GetComponent<Text>().text = text;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            textCanvas.SetActive(true);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Stopped Colliding!!");
        textCanvas.SetActive(false);
    }

}
