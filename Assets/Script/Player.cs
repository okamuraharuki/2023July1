using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CreatureSystem
{
    [SerializeField] static float _normalMove = 5;
    [SerializeField] float _slowMove = 3;
    [SerializeField] float _playerHp = 3;
    bool _hitted = false;
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
        if (_hitted)
        {
            Hit();
        }
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_hitted == false)
        {
            _playerHp = Damage(collision.gameObject, _playerHp, "EnemyBullet");
            _hitted = true;
            //Debug.Log("nowHp=" + _playerHp);}
        }
    }
    IEnumerator Hit() 
    { 
        yield return new WaitForSeconds(2);
        this.gameObject.GetComponent<Sprite>().Image.color.a = 
        _hitted = false;
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
