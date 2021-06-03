using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcontroller2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    
     Transform head_tr;

    float MouseX;
    float MouseY;
    public float sens = 3f;

    RaycastHit hit_object;
    void Start()
    {
      head_tr = GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;

        MouseY = Mathf.Clamp(MouseY, -90, 90);

        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);

        FindObjectOfType<BodyController>().Poluchatel(MouseX);
    }
}
