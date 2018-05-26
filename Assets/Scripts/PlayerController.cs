using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed, jump, frente;
    public Text pontuacao;
    private int score = 0;

    // Use this for initialization
    void Start () {
        pontuacao.text = "" + score;
	}


    // Update is called once per frame
    void FixedUpdate() {

        //transform.rotation = Quaternion.Euler(0, 0, 0);

        Vector3 nulo = new Vector3(0, GetComponent<Rigidbody>().velocity.y, frente);
        Vector3 dir = new Vector3(1, 0, 0);
        Vector3 dir2 = new Vector3(0, 1, 0);

        GetComponent<Rigidbody>().velocity = nulo;

        if (Input.GetButton("Right") && this.transform.position.x < 4.1)
        {
            //if (GetComponent<Rigidbody>().velocity.x == 0)
            //{
                GetComponent<Rigidbody>().velocity = speed * dir + nulo;
                //transform.rotation = Quaternion.Euler(0, 15, 0);
            //}
            //else GetComponent<Rigidbody>().velocity = speed * nulo;
        }
        
        if (Input.GetButton("Left") && this.transform.position.x > -4.1)
        {
            //if (GetComponent<Rigidbody>().velocity.x == 0)
            //{
                GetComponent<Rigidbody>().velocity = -speed * dir + nulo;
                //transform.rotation = Quaternion.Euler(0, -15, 0);
            //}
            //else GetComponent<Rigidbody>().velocity = speed * nulo;
        }
        

        if (Input.GetButtonDown("Jump") && this.transform.position.y < -0.4)
        {
            GetComponent<Rigidbody>().velocity = jump * dir2;
        }

        pontuacao.text = "" + score;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "alien")
        {
            score += 100;
        }
        else if (col.tag == "pessoa")
        {
            gameOver();
        }
    }


    public void gameOver()
    {
        SceneManager.LoadScene(0);
    }


}