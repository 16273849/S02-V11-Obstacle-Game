using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{    
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hitted") 
        {
            hits++;
            Debug.Log("Bumped into a thing "+ hits + " times.");
            other.gameObject.tag = "Hitted";
        }
    }
}
