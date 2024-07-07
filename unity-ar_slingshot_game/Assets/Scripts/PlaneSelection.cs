using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundations;
using UnityEngine.XR.ARSubsystems;

public class PlaneSelection : MonoBehaviour
{

    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    public GameObject strtBttn;
    public GameObject gmeM
    public void HideButton()
    {
        strtBttn.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
