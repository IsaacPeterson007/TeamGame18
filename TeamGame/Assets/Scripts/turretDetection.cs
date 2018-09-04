using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretDetection : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //Make sure you know that the turret is on somehow!! 
            Debug.Log("You have been found!!");
        }
    }
}
