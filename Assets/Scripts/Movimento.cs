using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {

    public float velocidade;

	// Use this for initialization
	void Start () {
        float x = Random.value;
        //if(velocidade == 1.5) velocidade += 2 * x;
        //if(velocidade == -1.5) velocidade -= 2 * x;
        if(velocidade != 0) velocidade += 2 * x;
    }
	
	// Update is called once per frame
	void Update () {

        if (this.transform.position.y < 0) transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);


        Vector3 direcao = new Vector3(transform.forward.x, 0, transform.forward.z);
        //if(velocidade > 0) direcao = new Vector3(1, 0, 0.2f);
        //else direcao = new Vector3(1, 0, -0.2f);

        GameObject referencia = GameObject.Find("Sphere");


        if (this.transform.position.z - referencia.transform.position.z < 10)
        GetComponent<Rigidbody>().velocity = velocidade * direcao;

        if(GameObject.Find("Sphere").transform.position.z - this.transform.position.z > 5) Destroy(this.gameObject);
    }
}
