using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour {

    //BERTO
    public int Puntos=0;
    public Text Victoria;
    public Text countPuntos;
    public float speed;
    float cuenta = 0;
    private Rigidbody rb;
    float saltar = 250f;
    private bool saltando = true;
    public Text caida;
    public Text nCaidas;
    public int numCaidas=1;
    public Transform Spawn;
    // Use this for initialization

    void Start() {
        
        rb = GetComponent<Rigidbody>();
        countPuntos.text = "Puntos: " + Puntos.ToString();
        nCaidas.text = "Intentos: " + numCaidas.ToString();
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Plata")
        {
            Puntos +=1;

            cuenta = 0;
            countPuntos.text = "Puntos: " + Puntos.ToString();
        }

        if (col.gameObject.tag=="Final"){

            Victoria.text = "VICTORIA, BIEN HECHO!!!";
        }

    }

    void FixedUpdate()
    {
    
        
        //rb.AddForce ( transform.position + transform.forward * speed * Time.deltaTime);
        //float moveVertical = Input.GetKeyDown(KeyCode.W);
        //float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(0f, 0.0f, 0.3f);

        if(rb.position.y <= -3)
        {
            caida.text = "MIERDA!";
        }
        if (rb.position.y <= -10)
        {

            speed = 5;
            transform.position = new Vector3(0f, 1.75f, 0.3f);
            numCaidas = numCaidas + 1;
            nCaidas.text = "Intentos: " + numCaidas.ToString();
            Puntos = 0;
            caida.text = "";
        }



        if (Input.GetButtonDown("Jump") && saltando == true && cuenta<2) { 
        
        saltando = true;
        cuenta += 1;
         salto();

        }
        rb.AddForce(movement * speed);

       
    }

    void salto()
    {

        rb.AddForce(Vector3.up * saltar);

    }


}

