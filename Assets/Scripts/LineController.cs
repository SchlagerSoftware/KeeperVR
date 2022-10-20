using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField]
    private GameObject line;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to check the position

        if(transform.position.x == 0.222) {
            print("Crossed the line on X axis");
        }

        if (transform.position.y == 0.008) {
            print("Crossed the line on Y axis");
        }

        if (transform.position.z == -22.196) {
            print("Crossed the line on Z axis");
        }
    }
}
