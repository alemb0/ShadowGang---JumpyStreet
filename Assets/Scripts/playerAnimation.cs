using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    public void HandleEndOfJump()
    {
        anim.SetBool("jump", false);
    }
}
