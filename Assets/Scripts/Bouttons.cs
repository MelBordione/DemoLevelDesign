using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouttons : MonoBehaviour
{
    public bool isTrigger = false;
    
    
    public Material Vert;
    public Material Rouge;
    public GameObject boutton;
   
 

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (!isTrigger)
        {
            isTrigger = true;
            boutton.GetComponent<SpriteRenderer>().material = Vert;

            

            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isTrigger)
        {
            
            isTrigger = false;
            boutton.GetComponent<SpriteRenderer>().material = Rouge;
        }
    }







    
}
