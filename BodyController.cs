using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BodyController : MonoBehaviour
{
    // Start is called before the first frame update
    float vertical;
    float horizontal;

    float yRotate;
    Transform tr;
    Rigidbody rg;
    float v;
    float h;
    Rigidbody rb;
    public GameObject  keypanel;
    public GameObject  key1;
    public GameObject  key2;
    public GameObject  key3;
    
    public GameObject HB;
    
    int hp = 100;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }
   
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");   
        rb.velocity = transform.forward * v * 10f;
        rb.AddForce(transform.right * h * 50f);
        if(Input.GetKeyDown("q"))
            {
               keypanel.SetActive(true);
               
               
            }

        
    }

    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
    
    void OnCollisionEnter(Collision collision )
    {
         if(collision.gameObject.tag=="kkey1")
        {
           key1.SetActive(true);
        }
        if(collision.gameObject.tag=="kkey2")
        {
           key2.SetActive(true);
        }
        if(collision.gameObject.tag=="kkey3")
        {
           key3.SetActive(true);
        }
        if(collision.gameObject.tag=="gate")
        {
          SceneManager.LoadScene("level1");
        }
    }
}
