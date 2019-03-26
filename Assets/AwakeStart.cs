using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class AwakeStart : MonoBehaviour
{
    Vector3 vector1 = new Vector3(1,0,0);
    Vector3 vector2 = new Vector3(0,1,0);
    Vector3 vector3 = new Vector3(1,1,0);
    Vector3 vector4 = new Vector3(7,9,10);
    Vector3 vector5 = new Vector3(7,3,5);
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sart AwakeStart");
        
        
        Debug.Log("Magnitud de vector 1: " + vector1.magnitude);
        Debug.Log("Producto punto entre dos vectores perpendiculares: " + Vector3.Dot(vector1, vector2));
        Debug.Log("Producto punto entre dos vectores no perpendiculares: " + Vector3.Dot(vector1, vector3));
        Debug.Log("Producto cruz entre dos vectores : " + Vector3.Cross(vector1, vector2));
        Debug.Log("Producto punto mal : " + Vector3.Dot(new Vector3(10, 0, 0), new Vector3(0, 0, 8)));
        
        
    }

    private void Awake()
    {
        Debug.Log("Awake AwakeStart");
    }

    private void Update()
    {
        //Debug.Log("Update deltaTime: " + Time.deltaTime);
        Debug.DrawLine(Vector3.zero, vector4, Color.white, 2.5f);
        Debug.DrawLine(Vector3.zero, vector5, Color.red, 2.5f);
        Debug.DrawLine(Vector3.zero, Vector3.Cross(vector4, vector5), Color.yellow, 2.5f);
    }

    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate deltaTime: " + Time.deltaTime);
    }
}
