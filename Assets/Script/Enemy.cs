using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CreatureSystem
{
    [SerializeField] float _enemyHp = 12;
    // Start is called before the first frame update
    private void Update()
    {
        Dead(_enemyHp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _enemyHp = Damage(collision.gameObject, _enemyHp,"PlayerBullet");
        //Debug.Log("nowHp=" + _enemyHp);
    }
}
