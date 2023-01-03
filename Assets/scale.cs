using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scale : MonoBehaviour
{
    public GameObject vbBtnObj;
    public GameObject terrainObj;
    public Material[] materials;
    private MeshRenderer meshRenderer;
   // public MeshRenderer Terrain_4;
    Vector3 temp;
   // public Material Decal;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        terrainObj = GameObject.Find("Terrain_2");

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        terrainObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //Terrain_4 = GetComponent<MeshRenderer>();
        meshRenderer = GetComponent<MeshRenderer>();
        //meshRenderer.sharedMaterial = material[1];
        //vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    // Update is called once per frame
    void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        
        //Destroy(terrainObj);
        terrainObj.SetActive(false);
        temp += new Vector3(2,2,2);
        transform.localScale = temp;
        Debug.Log("Button Pressed");

        if (Input.GetKeyDown(KeyCode.Space)){
 
                       meshRenderer.material = materials[1];
           }

    }
}
