﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{    
    [SerializeField] private float _movementSpeed;

    private bool _isMoving;

    public bool IsMoving => _isMoving;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(_movementSpeed * Time.deltaTime*-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(_movementSpeed * Time.deltaTime, 0, 0);
            }
            _isMoving = true;
        }
        else
        {
            _isMoving = false;
        }       
    }
}
