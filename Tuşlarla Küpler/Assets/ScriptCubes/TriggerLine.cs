using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLine : MonoBehaviour
{
   
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
