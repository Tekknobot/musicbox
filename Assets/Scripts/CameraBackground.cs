using UnityEngine;
using System.Collections;
 
public class CameraBackground : MonoBehaviour
{
    public Color red = Color.red;
    Camera cm;
 
    void Start()
    {
        cm = GetComponent<Camera>();
    }
 
    void Update()
    {
        if (Input.GetKeyUp ("Jump")) 
        {
            cm.backgroundColor = red;
        }
    }
}