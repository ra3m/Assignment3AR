using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    [SerializeField] GameObject Flashlight;
    private bool flashActive = false;

    // Start is called before the first frame update
    void Start()
    {
        Flashlight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashActive == false)
            {
                Flashlight.gameObject.SetActive(true);
                flashActive = true;
            }
            else
            {
                Flashlight.gameObject.SetActive(false);
                flashActive = false;
            }
        }
    }
}
