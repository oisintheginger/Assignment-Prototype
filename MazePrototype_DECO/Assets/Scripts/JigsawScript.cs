using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawScript : MonoBehaviour
{
    [SerializeField] GameObject[] gridSquares;

    bool[] gridCheck;

    bool allTrue;
    // Update is called once per frame
    
    void FixedUpdate()
    {   
       
        if(AllSquareFill()==true)
        {
            Debug.Log("Win");
        }
            
    }

    private bool AllSquareFill()
    {
        for (int i = 0; i< gridSquares.Length; i++)
        {
            if(gridSquares[i].GetComponent<SquareScript>().detectionS == false)
            {
                return false;
            }
        }
        return true;
    }
}
