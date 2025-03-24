using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBird : MonoBehaviour
{
    private Rigidbody2D _rb;
    private CircleCollider2D _circleCollider;

    private bool _hasBeenLanched;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _circleCollider = GetComponent<CircleCollider2D>();

        _rb.isKinematic = true;
        _circleCollider.enabled = false;
    }

    private void FixedUpdate()
    {
        if (_hasBeenLanched)
        {
            transform.right = _rb.velocity;
        }

    }
    public void LaunchBird(Vector2 direction, float force) 
    {
        _rb.isKinematic = false;
        _circleCollider.enabled = true;

        //apply force in the given direction
        _rb.AddForce(direction *  force, ForceMode2D.Impulse);

        _hasBeenLanched = true;
    }
}
