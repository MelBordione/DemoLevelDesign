using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvements : MonoBehaviour
{
    // -------------- Je me suis inspiré de l'exercice Integration de Personnage pour faire ce script --------------

    private Rigidbody2D rb;
    private AudioSource JumpSound;
    private Animator anim;

    // Variable pour vérifier le sol (permettre au personnage de sauter)
    public LayerMask whatIsGround;
    public Transform checkGround; //J'ai attaché un empty gameobject au personnage que j'associe a checkground

    //Variable de vitesse de mouvements et hauteur de saut
    private float mouvements;
    public float vitesse = 10f;
    public float powerJump = 10f;

    [SerializeField] private int multiplier = 1;

    //Sens du personnage
    private bool bonCote = true;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        JumpSound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(checkGround.position, 0.2f, whatIsGround);
        
    }

    private void FlipPlayer()
    {
        bonCote = !bonCote;
        Vector3 localScale = transform.localScale; // Récupere le localscale de l'object
        localScale.x *= -1f; //Multiplie le localscale en x de -1 pour retourner l'object
        transform.localScale = localScale; // initlaliser transform.localscale recupéré plus tot avec le multiplicateur -1 en x

    }

    public void Pause(InputAction.CallbackContext context)
    {
        if (context.performed)
            FindObjectOfType<GameManager>().Pause();


    }


    
    public void Move(InputAction.CallbackContext context)
    {
        mouvements = context.ReadValue<Vector2>().x * multiplier;
       

        anim.SetTrigger("AnimPlay");
       
        
        

       
    }

    public void Jump(InputAction.CallbackContext context) //J'ai fais le check Grounded directement dans la fonction jump
    {
        

        if (context.performed && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, powerJump);
            JumpSound.Play();
            


        }
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(mouvements * vitesse, rb.velocity.y);

        if (!bonCote && mouvements > 0f)
        {
            FlipPlayer();
        }
        else if (bonCote && mouvements < 0f)
        {
            FlipPlayer();
        }
    }
}
