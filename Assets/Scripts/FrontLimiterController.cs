using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontLimiterController : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            this.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
