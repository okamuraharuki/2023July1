using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveCurve : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed = 5;
    [SerializeField] float _curveSpeed = 3;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        _rb.AddForce(new Vector2(_curveSpeed / 30, 0));
    }
}
