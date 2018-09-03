using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStuf : MonoBehaviour {

    private bool canOpen;
    private bool isOpen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Player" && canOpen)
        {
            openDoor();
        }
    }

    public void openDoor()
    {
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
}
