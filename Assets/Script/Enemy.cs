using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : CreatureSystem
{
    [SerializeField] public float _enemyHp = 12;
    // Start is called before the first frame update
    private void Update()
    {
        Dead(_enemyHp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamagedHp(collision.gameObject);
    }
    public void DamagedHp(GameObject collision)
    {
        _enemyHp = Damage(collision, _enemyHp, "PlayerBullet");
        Debug.Log("nowHp=" + _enemyHp);
    }
}
