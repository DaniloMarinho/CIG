using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour {

    public Rigidbody zumbi11, zumbi12, zumbi13, zumbi21, zumbi22, zumbi23, zumbi31, zumbi32, zumbi33;
    public Rigidbody pessoa;
    public float taxa;
    bool prepara = false, pes = true;

    // Use this for initialization
    void Start () {
        taxa = 2;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.timeSinceLevelLoad % 12 > 10)
        {
            if (pes == true)
            {
                Rigidbody clone;
                float d = Random.value;
                Vector3 pos = new Vector3(8*(0.5f-d), 0, this.transform.position.z + 10 + 2.1f*(taxa-2));
                clone = Instantiate(pessoa, pos, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                pes = false;
            }
        }
        else
        {
            pes = true;
            if (taxa <= 4) taxa = 2 + 0.03f * Time.timeSinceLevelLoad;
            if (taxa * Time.timeSinceLevelLoad % 2 < 1)
            {
                prepara = true;
            }
            if (taxa * Time.timeSinceLevelLoad % 2 > 1 && prepara == true)
            {
                Rigidbody clone;
                Vector3 direcao = new Vector3(1, 0, 0);
                float d = Random.value;
                Vector3 pos1 = new Vector3(-4.2f + 3 * d, 0, this.transform.position.z + 10);
                Vector3 pos2 = new Vector3(4.2f - 3 * d, 0, this.transform.position.z + 10);
                Vector3 pos3 = new Vector3(8.5f * (0.5f - d), 0, this.transform.position.z + 10);
                Quaternion rot1 = Quaternion.Euler(0, 110 + 50 * d, 0);
                Quaternion rot2 = Quaternion.Euler(0, 250 - 50 * d, 0);
                Quaternion rot3 = Quaternion.Euler(0, -10 * d, 0);

                float x = 9 * Random.value;
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
}
