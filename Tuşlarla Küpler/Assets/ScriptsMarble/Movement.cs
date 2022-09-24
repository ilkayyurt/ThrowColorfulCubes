using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float force = 75;
    public GameManage gm;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal") * force * Time.deltaTime;
        float vInput = Input.GetAxis("Vertical") * force * Time.deltaTime;
        rb.AddForce(hInput, 0, vInput);
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "diamond")
        {
            Destroy(collision.gameObject);
            gm.diamond += 1;
            
            Debug.Log("Diamond is collected.");
        }
    }
}
