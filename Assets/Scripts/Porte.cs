using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{

    private Animator door;

    public Bouttons boutton1;
    public Bouttons boutton2;    // Références aux script pour pouvoir activer les boutons


    private void Start()
    {
        door = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(boutton1.isTrigger && boutton2.isTrigger)
        {
            door.SetTrigger("Open");
        }
    }
}
