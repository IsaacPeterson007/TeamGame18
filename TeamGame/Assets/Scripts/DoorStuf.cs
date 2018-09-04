using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStuf : MonoBehaviour {

    private bool canOpen;
    private bool isOpen;

	// Use this for initialization
	void Start () {
        isOpen = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.gameObject.name + " is in trigger");
        if(other.gameObject.name == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            openDoor();
        }
    }

    public void openDoor()
    {
        Debug.Log("door opened");
        if (isOpen)
        {
            transform.Translate(new Vector3(0, -10, 0));
            isOpen = false;
        }
        else
        {
            transform.Translate(new Vector3(0, 10, 0));
            isOpen = true;
        }
    }

    //&& canOpen && Input.GetKeyDown(KeyCode.E)
}
