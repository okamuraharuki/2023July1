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
            Hp -= collisionGameObject.GetComponent<Status>()._damage;//�e�𐔎�ލ��\��
            Debug.Log("FinishDamage.damage quantity is " + collisionGameObject.GetComponent<Status>()._damage + "Now HP is " + Hp);
            //Todo�@������Hp�̒l��float�@Hp�̎Q�l���ɕԂ��v���O����������
            //      �������͂���ɏ����铮���ɂ���
        }
    }
    public void Dead(float Hp)
    {
        if (Hp <= 0)
        Destroy(this.gameObject);
    }
}
