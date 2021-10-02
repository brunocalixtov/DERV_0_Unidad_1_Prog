using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmientoBasico : MonoBehaviour
{

    public float desplazamiento = 10;

    //long i;


    // Start is called before the first frame update
    void Start()
    {
        //i = 0;    
    }

    
    // Update is called once per frame
    void Update()
    {        
        Debug.Log("Prueba");
        //Debug.Log("Prueba " + i);
        //i++;

        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("Arriba");
            transform.Translate(Vector3.forward* desplazamiento * Time.deltaTime);
            //new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            transform.Translate(Vector3.left * desplazamiento * Time.deltaTime);        
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Abajo");
            transform.Translate(Vector3.back * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            transform.Translate(Vector3.right * desplazamiento * Time.deltaTime);
        }



    }
}
