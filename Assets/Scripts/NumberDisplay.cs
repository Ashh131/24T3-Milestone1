using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 2; i<= 20; i += 2)
        {
            Debug.Log("The current number is" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
