using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    private Animator animator;

    public Door()
    {

    }


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
