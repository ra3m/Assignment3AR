using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomControl : MonoBehaviour
{
    public Camera mainCam;
    public float speed = 1;

    private bool buttonReleased;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            buttonReleased = false;
            if(mainCam.fieldOfView >= 45)
            {
                mainCam.fieldOfView -= 1;
            }
        }

        if(Input.GetMouseButtonUp(1))
        {
            buttonReleased=true;
        }

        if(buttonReleased)
        {
            if(mainCam.fieldOfView <= 60)
            {
                mainCam.fieldOfView += 10;
            }
        }
    }
}
