using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    [SerializeField]
    private GameObject cubeObject;
    private GameObject clone;
    Color[] colors = { Color.red, Color.blue, Color.magenta, Color.yellow };
    KeyCode[] keyCodes = { KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F };

    //public GameObject cubeObject2;


    //public GameObject cubeObject3;

    //public GameObject cubeObject4 ;

    void Start()
    {

        //GameObject cubeObject = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //cubeObject.transform.localPosition = new Vector3(2, 10, 12);
        //cubeObject.transform.localScale = new Vector3(1, 1, 1);
        //cubeObject.GetComponent<MeshRenderer>().material.color = Color.red;

        //GameObject cubeObject2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //cubeObject2.transform.localPosition = new Vector3(2, 10, 13);
        //cubeObject2.transform.localScale = new Vector3(1, 1, 1);
        //cubeObject2.GetComponent<MeshRenderer>().material.color = Color.blue; 

        //GameObject cubeObject3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //cubeObject3.transform.localPosition = new Vector3(2, 10, 14);
        //cubeObject3.transform.localScale = new Vector3(1, 1, 1);
        //cubeObject3.GetComponent<MeshRenderer>().material.color = Color.yellow;

        //GameObject cubeObject4 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //cubeObject4.transform.localPosition = new Vector3(2, 10, 15);
        //cubeObject4.transform.localScale = new Vector3(1, 1, 1);
        //cubeObject4.GetComponent<MeshRenderer>().material.color = Color.magenta;

        for (int i = 0; i < 4; i++)
        {
            clone = Instantiate(cubeObject);
            clone.GetComponentInChildren<MeshRenderer>().material.color = colors[i];
            clone.transform.position = new Vector3(i-3f/2,-4,5);
            clone.GetComponent<Keys>().keyCode = keyCodes[i];
        }

    }
    void Update()
    {



        
       //if (Input.GetKeyDown(KeyCode.A))
       //{
       //    Instantiate(cubeObject, transform.position, Quaternion.identity);
       //}

       //else if (Input.GetKeyDown(KeyCode.S))
       // {
       //     Instantiate(cubeObject2, transform.position, Quaternion.identity);
       // }
       // else if (Input.GetKeyDown(KeyCode.D))
       // {
       //     Instantiate(cubeObject3, transform.position, Quaternion.identity);
       // }
       // else if (Input.GetKeyDown(KeyCode.F))
       // {
       //     Instantiate(cubeObject4, transform.position, Quaternion.identity);
       // }



    }
}
