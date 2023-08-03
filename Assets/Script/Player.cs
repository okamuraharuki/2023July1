using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Player : CreatureSystem
{
    [SerializeField] static float _normalMove = 5;
    [SerializeField] float _slowMove = 3;
    [SerializeField] float _playerHp = 3;
    [SerializeField] bool _hit = false;
    Rigidbody2D _rb;
    Animator _anim;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        Dead(_playerHp);
        Hit();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_hit == false)
        {
            _playerHp = Damage(collision.gameObject, _playerHp, "EnemyBullet");
            _hit = true;
            Debug.Log("nowHp=" + _playerHp);
        }
    }
    private void Hit()
    {
        if (_hit)
        {
            StartCoroutine(IHit());
        }
    }
    IEnumerator IHit()
    {
        //this.gameObject.GetComponent<Sprite>().Image.color.a = 
        yield return new WaitForSeconds(2);
        _hit = false;
    }
    private void Move()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        Vector2 playerdir = new Vector2(hori, vert);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _rb.velocity = playerdir.normalized * _slowMove;
        }
        else
        {
            _rb.velocity = playerdir.normalized * _normalMove;
        }
    }

}
