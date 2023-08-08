using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveStraight : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _bulletSpeed = 5; 
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector3(0,-1,0) * _bulletSpeed;
    }
}
