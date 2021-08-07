using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsBall : MonoBehaviour
{
    private Rigidbody2D _rigibody;
    private bool _inGround = false;

    private void Start()
    {
        
        _rigibody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _inGround)
        {
            _rigibody.gravityScale *= -1;
        }
    }

    private void OnTriggerStay2D(Collider2D collision) => _inGround = true;

    private void OnTriggerExit2D(Collider2D collision) =>_inGround = false;
}
