using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float xSensitivity = 200;
    public float ySensitivity = 150;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject head;

    public float top = -60;
    public float bottom = 60;
    private float rot;
	
	// Update is called once per frame
	void Update () {

        //get input
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");

        //rotate character
        player.transform.RotateAround(player.transform.position, Vector3.up, 
            xInput * Time.deltaTime * xSensitivity);

        //rotate head
        rot += -yInput * Time.deltaTime * ySensitivity;
        rot = Mathf.Clamp(rot, top, bottom);
        head.transform.localEulerAngles = new Vector3(rot, 0, 0);

    }
}
