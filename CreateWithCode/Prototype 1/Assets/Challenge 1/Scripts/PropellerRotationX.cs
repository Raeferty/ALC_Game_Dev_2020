using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotationX : MonoBehaviour
{

    public float rotationSpeed;



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

    }
}
