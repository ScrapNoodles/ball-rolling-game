using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed;
    public bool thing = false;

    float x, y, z = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){ //start button 
            while (thing == false)
            {
                x = speed;
                transform.Translate(x, y, z);
                if (Input.GetMouseButtonDown(0) && z == speed) // changing to x
                {
                    Debug.Log("lmb pressedX");
                    x = speed; y = 0; z = 0;
                } else if (Input.GetMouseButtonDown(0) && x == speed) // changing to z
                {
                    Debug.Log("lmb pressedZ");
                    x = 0; y = 0; z = speed;
                }
            }//end while
        }

    }
}
