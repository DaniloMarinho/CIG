using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed, /*jump,*/ frente;
    public Text pontuacao;
    private int score = 0;

    // Use this for initialization
    void Start () {
        pontuacao.text = "" + score;
	}


    // Update is called once per frame
    void FixedUpdate() {

        Vector3 nulo = new Vector3(0, GetComponent<Rigidbody>().velocity.y, frente);
        Vector3 dir = new Vector3(1, 0, 0);
        Vector3 dir2 = new Vector3(0, 1, 0);

        GetComponent<Rigidbody>().velocity = nulo;

        if (Input.GetButton("Right") && this.transform.position.x < 4.1)
        {
                GetComponent<Rigidbody>().velocity = speed * dir + nulo;
        }
        
        if (Input.GetButton("Left") && this.transform.position.x > -4.1)
        {
                GetComponent<Rigidbody>().velocity = -speed * dir + nulo;
        }
        

        /*if (Input.GetButtonDown("Jump") && this.transform.position.y < -0.4)
        {
            GetComponent<Rigidbody>().velocity = jump * dir2;
        }*/

        pontuacao.text = "" + score;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "alien")
        {
            col.tag = "Untagged";
            //GetComponent<col.gameObject.Rigidbody.velocity.y>() = 1;
            //col.gameObject.GetComponent<AudioVelocityUpdateMode>() = 1;
            //score += 100;
            speed -= 0.2f;
            if (speed <= 5) speed -= 0.2f;
            if (speed <= 4) speed -= 0.2f;
            if (speed <= 3)
            {
                gameOver();
            } 
        }
        if(col.tag == "pessoa")
        {
            score++;
            Destroy(col.gameObject);
        }
    }
    

    public void gameOver()
    {
        SceneManager.LoadScene(0);
    }


}