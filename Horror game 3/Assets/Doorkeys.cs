using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorkeys : MonoBehaviour
{
    public bool IsTrigger;

    private void OnTriggerEnter(Collider other)
    {
        IsTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        IsTrigger = false;
    }

    void OnGUI()    
    {
        if (IsTrigger)
        {
         GUI.Box(new Rect(0, 0, 200, 25), "Press F to take key");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F))            
            {
                DorScript.doorKey = true;
                

                
                Destroy(this.gameObject);
            }
        }
    }
}
