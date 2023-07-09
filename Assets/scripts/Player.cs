using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : CreatureSystem
{
    [SerializeField] float _normalMove = 5;
    [SerializeField] float _slowMove = 3;
    [SerializeField] float _playerHp = 3;
    Rigidbody2D _rb;
    Animator _anim;
    private void Start()
    {
        //CreatureDefine(_playerHp,_rb,_anim);
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        Dead(_playerHp);
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "MovableSpace")
        {
            Damage(collision.gameObject, _playerHp,"EnemyBullet");
        }
    }
    private void Move()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        Vector2 playerdir = new Vector2(hori, vert);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _rb.velocity = playerdir * _slowMove;
        }
        else
        {
            _rb.velocity = playerdir * _normalMove;
        }
    }
}