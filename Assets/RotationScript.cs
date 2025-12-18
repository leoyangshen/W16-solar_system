using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float rotationSpeed;
    public float dampAmt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate((Vector3.up * rotationSpeed) * (Time.deltaTime * dampAmt), Space.Self); 
    }
}
