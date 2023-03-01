using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCube : MonoBehaviour
{
    [SerializeField] float y = 0f;
    [SerializeField] float moveSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(x,y,z);
    }
}
