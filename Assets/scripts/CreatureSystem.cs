using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class CreatureSystem : MonoBehaviour
{
    //public void CreatureDefine(float Hp,Rigidbody2D Rb,Animator Anim)
    //{
    //    Anim = GetComponent<Animator>();
    //    Rb = GetComponent<Rigidbody2D>();
    //    _hp = Hp;
    //}
    public void Damage(GameObject collisionGameObject,float Hp,string tag)
    {
        if (collisionGameObject.tag == tag)
        {
            Debug.Log("StartDamage");
            Hp -= collisionGameObject.GetComponent<Status>()._damage;//弾を数種類作る予定
            Debug.Log("FinishDamage.damage quantity is " + collisionGameObject.GetComponent<Status>()._damage + "Now HP is " + Hp);
            //Todo　ここにHpの値をfloat　Hpの参考元に返すプログラムを書く
            //      もしくはそれに準ずる動きにする
        }
    }
    public void Dead(float Hp)
    {
        if (Hp <= 0)
        Destroy(this.gameObject);
    }
}
