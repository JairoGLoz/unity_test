using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    public int edad = 8/2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sart TestScript");
        gameObject.GetComponent<TestScript>().edad = 5; 
        this.edad = 8;
    }

    private void Awake()
    {
        Debug.Log("Awake TestScript");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Tecla R presionada");
            gameObject.GetComponent<Renderer>().materials[0].color = Color.red;
        }
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Tecla R presionada");
            gameObject.GetComponent<Renderer>().materials[0].color = Color.green;
        }
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Tecla R presionada");
            gameObject.GetComponent<Renderer>().materials[0].color = Color.blue;
        }
    }

}
