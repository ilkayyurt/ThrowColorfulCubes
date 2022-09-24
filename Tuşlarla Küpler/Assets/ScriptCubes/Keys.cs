using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    internal KeyCode keyCode;
    private GameObject clone;
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            clone=Instantiate(gameObject);
            clone.transform.position += Vector3.up;
            clone.transform.localScale = new Vector3(.9f,0,1);
        }
        if (Input.GetKey(keyCode))
        {
            clone.transform.localScale += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKeyUp(keyCode))
        {
            clone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }
    }
    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            clone.GetComponent<Rigidbody>().velocity = Vector3.up;
        }
    }
}
