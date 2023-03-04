using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    
    
   

    


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
        

    }

   

    

    public void PlayerDie()    
    {

        
        FindObjectOfType<GameManager>().GameOver();

       


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Ennemie")
        {

            PlayerDie();
        }

        if (collision.collider.tag =="Water")
        {

        }

        
    
    }





    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < -18.0f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
