using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    public bool detectionS;
    // Start is called before the first frame update
    void Start()
    {
        detectionS = false;
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Square")
        {
            detectionS = true;
        }

        
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Square")
        {
            detectionS = false;
        }
    }
}
