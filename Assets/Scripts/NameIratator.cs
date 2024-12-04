using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameIratator : MonoBehaviour
{
    private string[] NAMES = { "Alice", "Bob", "Charlie", "David", "Eve" };
    // Start is called before the first frame update
    void Start()
    {
        foreach (string name in NAMES)
        {
            Debug.Log("Name: " + name);
        }
    }

    
        
    
}
