using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughManager : MonoBehaviour
{

    public OVRPassthroughLayer passthrough;
    public OVRInput.Button button;
    public OVRInput.Controller controller;

    void Start()
    {

    }

    void Update()
    {
        
        if (OVRInput.GetDown(button, controller))
        {
            Debug.Log("pinched");
            passthrough.hidden = !passthrough.hidden;
        }
    }
}
