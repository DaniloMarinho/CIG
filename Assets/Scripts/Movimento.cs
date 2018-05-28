using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {

    public float velocidade;
    public bool b;

	// Use this for initialization
	void Start () {
        //float x = Random.value;
        //if(velocidade != 0) velocidade += 2 * x;
        if(b == true) GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX;
    }
	
	// Update is called once per frame
	void Update () {

        if (this.transform.position.y < 0 && this.transform.position.z - GameObject.Find("Sphere").transform.position.z < 2) transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);

        Vector3 direcao = new Vector3(transform.forward.x, 0, transform.forward.z);
        //Vector3 perp = GameObject.Find("ref1").transform.position - GameObject.Find("ref2").transform.position;
        //Vector3 project = Vector3.ProjectOnPlane(transform.forward, perp);

        GameObject referencia = GameObject.Find("Sphere");

        if (this.transform.position.z - referencia.transform.position.z < 10)
        GetComponent<Rigidbody>().velocity = velocidade * direcao;

        if(GameObject.Find("Sphere").transform.position.z - this.transform.position.z > 5) Destroy(this.gameObject);
        if (this.transform.position.z - GameObject.Find("Sphere").transform.position.z < 1.2 && this.transform.position.x - GameObject.Find("Sphere").transform.position.x < 0.5f && this.transform.position.x - GameObject.Find("Sphere").transform.position.x > -0.5f)
        if(b == true) GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezeRotationX;

    }

        /*private void OnTriggerEnter(Collider col){
            if (col.tag == "car"){
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 10, GetComponent<Rigidbody>().velocity.z);
            }
        }*/
    }
