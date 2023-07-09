using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CreatureSystem
{
    [SerializeField] float _enemyHp = 12;
    // Start is called before the first frame update
    void Update()
    {
        Dead(_enemyHp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "MovableSpace")
        {
            Damage(collision.gameObject, _enemyHp,"PlayerBullet");
        }
    }
}
