using UnityEngine;
using System.Collections;

public class lighthouseRotation : MonoBehaviour {

    public float light_rotationSpeed;    
    	
	void Update () {    
    transform.Rotate(Vector3.up * Time.deltaTime * light_rotationSpeed, Space.World);
    }
}
