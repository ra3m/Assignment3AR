using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class destroy : MonoBehaviour
{
    public GameObject vbBtn2Obj;
    public GameObject terrain2Obj;

    // Start is called before the first frame update
    void Start()
    {
        vbBtn2Obj = GameObject.Find("VirtualButton2");
        terrain2Obj = GameObject.Find("Terrain_4");

        vbBtn2Obj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    // Update is called once per frame
    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Destroy(terrain2Obj);
        Debug.Log("Button Pressed");
    }
}
