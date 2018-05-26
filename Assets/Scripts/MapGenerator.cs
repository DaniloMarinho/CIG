using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public int taxaMapa;
    public Transform mapa;
    bool prepara = false;
    bool fechou = false;
    GameObject referencia;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        referencia = GameObject.Find("Sphere");

        if (Time.timeSinceLevelLoad % taxaMapa < 1 && Time.timeSinceLevelLoad > 10)
        {
            prepara = true;
        }
        if (Time.timeSinceLevelLoad % taxaMapa > 1 && prepara == true && fechou == false)
        {
            Vector3 pos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 100);
            Instantiate(mapa, pos, Quaternion.Euler(0, 0, 0));
            fechou = true;
        }
        if(referencia.transform.position.z - this.transform.position.z  > 52 && fechou == true)
        {
            Destroy(this.gameObject);
        }
    }
}
