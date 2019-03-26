using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{

    public float speed = 7.0f;
    public float rotationSpeed = 100f;

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("Up Arrow");
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            anim.SetFloat("speed", speed);
        }else if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(Vector3.up,  Time.deltaTime * -rotationSpeed);
            anim.SetFloat("speed", speed);
        }else if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(Vector3.up,  Time.deltaTime * +rotationSpeed);
            anim.SetFloat("speed", speed);
        }
        else
        {
            anim.SetFloat("speed", 0.0f);
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("attack");
            //Debug.Log("Space pressed");
        }
        
    }
}
