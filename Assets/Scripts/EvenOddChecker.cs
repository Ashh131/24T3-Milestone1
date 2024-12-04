using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenOddChecker : MonoBehaviour
{
    public int numberToCheck = 5;
    // Start is called before the first frame update
    private void Start()
    {
        if (numberToCheck % 2 == 0)
        {
            Debug.Log(numberToCheck + "is even.");

        }
        else
        {
            Debug.Log(numberToCheck + "is odd.");
        }
    }

   
  
}
