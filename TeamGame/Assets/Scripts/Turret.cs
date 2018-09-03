using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {



    private bool isOn;
    private float rotation;
    private bool turn;

    [SerializeField] private GameObject los;
    [SerializeField] private float startAngle;
    [SerializeField] private float endAngle;
    [SerializeField] private float turnSpeed;

    // Use this for initialization
    void Start () {
        isOn = true;
        rotation = startAngle;
        turn = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isOn)
        {
            los.SetActive(true);
            turnTurret();
        }
        else
        {
            los.SetActive(false);
        }
	}

    private void turnTurret()
    {
        if (turn)
        {
            rotation += turnSpeed * Time.deltaTime;
            if(rotation >= startAngle)
            {
                turn = false;
            }
        }
        else
        {
            rotation -= turnSpeed * Time.deltaTime;
            if (rotation <= endAngle)
            {
                turn = true;
            }
        }
        transform.localEulerAngles = new Vector3(0, rotation, 0);
    }

    public void enableTurret()
    {
        isOn = true;
    }

    public void disableTurret()
    {
        isOn = false;
    }
}
