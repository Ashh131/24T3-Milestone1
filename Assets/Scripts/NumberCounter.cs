using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCounter : MonoBehaviour
{
    public int targetNumber = 10;
    private int currentNumber = 1;
  
    // Start is called before the first frame update
   private void Start()
    {
        while (currentNumber <= targetNumber)
        {
            Debug.Log("Number: " + currentNumber);
         currentNumber++;
        }
    }

    
   
}
