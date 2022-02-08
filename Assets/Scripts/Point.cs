using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
  
    // Update is called once per frame
    void Update () 
	{
		transform.Rotate(new Vector3(0,90,0)* Time.deltaTime);
	}

	void onTriggerEnter(Collider other)
    {
            Debug.Log("Collide");
    }
	
}
