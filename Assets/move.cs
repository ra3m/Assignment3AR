using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class move : MonoBehaviour
{

    float inputX, inputZ;

    void Update() {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        if (inputX != 0)
            rotate();
        if (inputZ != 0)
            moved();
    }

    private void rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime, 0f));
    }

    private void moved()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime;
    }
}
