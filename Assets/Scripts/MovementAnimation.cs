using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    [SerializeField] private Animator _animator;

    void Update()
    {
        if (_movement.CurentSpeed > 0)
        {
            _animator.SetBool("WalkOn", true);
        }
        else
        {
            _animator.SetBool("WalkOn", false);
        }
    }


}
