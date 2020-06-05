using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Movement))]
public class MovementAnimation : MonoBehaviour
{
    private Movement _movement;    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<Movement>();
    }

    void Update()
    {
        if (_movement.IsMoving == true)
        {
            _animator.SetBool("WalkOn", true);
        }
        else
        {
            _animator.SetBool("WalkOn", false);
        }
    }


}
