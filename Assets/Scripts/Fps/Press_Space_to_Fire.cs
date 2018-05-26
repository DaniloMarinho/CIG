
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press_Space_to_Fire : MonoBehaviour
{
    public Rigidbody zumbi11;
    public float velocidadeinicial;
    public float speed1, jump1, frente1;
    GameObject referencia;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        referencia = GameObject.Find("Sphere");
        if (Input.GetButton("Fire1"))
        {
            Quaternion rot3 = Quaternion.Euler(0, 210, 0);
            
            Vector3 nulo1 = new Vector3(0, GetComponent<Rigidbody>().velocity.z, frente1);
            Vector3 dir1 = new Vector3(0, 0, 1);
            Vector3 pos2 = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), referencia.transform.position.z);
            GetComponent<Rigidbody>().velocity = speed1 * dir1 + nulo1;
            Rigidbody clone1;
            clone1 = Instantiate(zumbi11, pos2, rot3) as Rigidbody;

        }
    }


}
