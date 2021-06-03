using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class playercontr : MonoBehaviour
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
    public GameObject HB;
    public GameObject player;
    Slider slider_hb;
    
    
    int hp = 100;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        slider_hb = HB.GetComponent<Slider>();
        
        
        
    }
   
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");   
        rb.velocity = transform.forward * v * 10f;
        rb.AddForce(transform.right * h * 50f);
        if(hp == 0)
        {
            Destroy(player);
        }
        

        
    }

    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
     void OnCollisionEnter(Collision collision )
    {
         if(collision.gameObject.tag=="enemy")
        {
            hp = hp - 10;
            slider_hb.value = hp;
        } 
    }


    
    
    
   
}
