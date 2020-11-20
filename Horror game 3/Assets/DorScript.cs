using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorScript : MonoBehaviour
{

    public static bool doorKey;
    public  bool open;
    public  bool close;
    public bool isTrigged;



    void OnTriggerEnter(Collider other) {

        isTrigged = true;       
    
    
    }
    void OnTriggerExit(Collider other)
    {

        isTrigged = false;


    }
    void OnGUI()
    {
        if (isTrigged)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press F to close ");

            }
            else 
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press F to open ");
                }   
                else 
                {
                     GUI.Box(new Rect(0, 0, 200, 25), "Need Key");

                }
            }
        }
    
    
    
    }

    // Start is called before the first frame update
    void Start()
    {
            
        
        
    }

    // Update is called once per frame
    void Update()
    {


        if (isTrigged)
        {
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        open = true;
                       

                        close = false;

                    }
                }
            }
            else 
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        close = true;
                        open = false;

                    }

                }
                   
        }
        if (isTrigged)
        {
            if (open)
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 200);
                transform.rotation = newRot;
            }
            else {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
                transform.rotation = newRot;

            }
        
        
        
        }
        
        
        
    }


}
