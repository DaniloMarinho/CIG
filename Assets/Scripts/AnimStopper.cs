using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStopper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z - GameObject.Find("Sphere").transform.position.z < 1.2 && this.transform.position.x - GameObject.Find("Sphere").transform.position.x < 0.5f && this.transform.position.x - GameObject.Find("Sphere").transform.position.x > -0.5f)
            GetComponent<Animator>().enabled = false;
    }
}
