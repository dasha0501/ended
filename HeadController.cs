using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    
    Transform head_tr;

    float MouseX;
    float MouseY;
    public float sens = 3f;

    RaycastHit hit_object;
    public GameObject  pismopanel;
   
    
    int check = 0;
    
    
    void Start()
    {
        head_tr = GetComponent<Transform>();

       
    }


    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;

        MouseY = Mathf.Clamp(MouseY, -90, 90);

        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);

        FindObjectOfType<BodyController>().Poluchatel(MouseX);
        Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);
        
        if(Physics.Raycast(transform.position, transform.forward, out hit_object , 3f))
        {
            if(hit_object.collider.gameObject.tag=="kvest")
            {
                pismopanel.SetActive(true);
            }
           
        }
         if(Input.GetKeyDown("e"))
            {
                pismopanel.SetActive(false);
            }
    }
}
