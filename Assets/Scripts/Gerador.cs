using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour {

    public Rigidbody zumbi11, zumbi12, zumbi13, zumbi21, zumbi22, zumbi23, zumbi31, zumbi32, zumbi33;
    public float taxa;
    bool prepara = false;

    // Use this for initialization
    void Start () {
        taxa = 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (taxa <= 5) taxa = 2 + 0.03f * Time.timeSinceLevelLoad;
        if (taxa*Time.timeSinceLevelLoad % 2 < 1)
        {
            prepara = true;
        }
        if (taxa*Time.timeSinceLevelLoad % 2 > 1 && prepara == true)
        {
            Rigidbody clone;
            Vector3 direcao = new Vector3(1, 0, 0);
            float d = Random.value;
            Vector3 pos1 = new Vector3(-4 + d, 0, this.transform.position.z + 10);
            Vector3 pos2 = new Vector3(4 - d, 0, this.transform.position.z + 10);
            Vector3 pos3 = new Vector3(8*(0.5f-d), 0, this.transform.position.z + 10);
            Quaternion rot1 = Quaternion.Euler(0, 130 + 30 * d, 0);
            Quaternion rot2 = Quaternion.Euler(0, 230 - 30 * d, 0);
            Quaternion rot3 = Quaternion.Euler(0, 0, 0);

            float x = 9*Random.value;
            switch ((int)x % 9)
            {
                case 0:
                    clone = Instantiate(zumbi11, pos1, rot1) as Rigidbody;
                    break;
                case 1:
                    clone = Instantiate(zumbi12, pos1, rot1) as Rigidbody;
                    break;
                case 2:
                    clone = Instantiate(zumbi13, pos1, rot1) as Rigidbody;
                    break;
                case 3:
                    clone = Instantiate(zumbi21, pos2, rot2) as Rigidbody;
                    break;
                case 4:
                    clone = Instantiate(zumbi22, pos2, rot2) as Rigidbody;
                    break;
                case 5:
                    clone = Instantiate(zumbi23, pos2, rot2) as Rigidbody;
                    break;
                case 6:
                    clone = Instantiate(zumbi31, pos3, rot3) as Rigidbody;
                    break;
                case 7:
                    clone = Instantiate(zumbi32, pos3, rot3) as Rigidbody;
                    break;
                case 8:
                    clone = Instantiate(zumbi33, pos3, rot3) as Rigidbody;
                    break;
                default: break;
            }
            prepara = false;
        }
    }

}
