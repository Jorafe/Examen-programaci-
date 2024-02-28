using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mariomovement :MonoBehaviour

{

    public Transform translate;


    public float Speed;

    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         if(Input.GetKey(KeyCode.D))
         {
            transform.Translate(Speed,0,0);
         }
         
         if(Input.GetKey(KeyCode.A))
         {
      
            transform.Translate(-Speed,0,0);
         }

         if(Input.GetKey(KeyCode.Space))
         {
            transform.Translate(0,jump,0);
         }
    }
}
