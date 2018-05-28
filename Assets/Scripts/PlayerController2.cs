using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{

    public float speed2, frente2;
    public Text pontuacao2;
    private int score2 = 0;

    // Use this for initialization
    void Start()
    {
        pontuacao2.text = "" + score2;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 nulo = new Vector3(0, GetComponent<Rigidbody>().velocity.y, frente2);
        Vector3 dir = new Vector3(1, 0, 0);
        Vector3 dir2 = new Vector3(0, 1, 0);

        GetComponent<Rigidbody>().velocity = nulo;

        if (Input.GetButton("Right"))
        {
            GetComponent<Rigidbody>().velocity = speed2 * dir + nulo;
        }

        if (Input.GetButton("Left"))
        {
            GetComponent<Rigidbody>().velocity = -speed2 * dir + nulo;
        }  

        pontuacao2.text = "" + score2;

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "alien")
        {
            col.tag = "Untagged";
            score2 += 100;
            speed2 -= 0.2f;
            if (speed2 <= 5) speed2 -= 0.2f;
            if (speed2 <= 4)
            {
                gameOver2();
            }
        }
    }


    public void gameOver2()
    {
        SceneManager.LoadScene(0);
    }


}