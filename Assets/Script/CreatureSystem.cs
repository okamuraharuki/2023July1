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
    public float Damage(GameObject collisionGameObject,float Hp,string tag)
    {
        if (collisionGameObject.tag == tag || tag == "Bomb")
        {
            //Debug.Log("StartDamage");
            Hp -= collisionGameObject.GetComponent<Status>()._damage;//’e‚ğ”í—Şì‚é—\’è
        }
        return Hp;
    }
    public void Dead(float Hp)
    {
        if (Hp <= 0)
        Destroy(this.gameObject);
    }
}
