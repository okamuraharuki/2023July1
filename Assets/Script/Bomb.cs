using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    Transform _playerPos;
    [SerializeField] float _explodeDistance = 5;
    GameObject[] _bombedObjects = default;
    void Start()
    {

    }

    void Update()
    {
        _playerPos = GameObject.FindWithTag("Player").transform;
    }
    public void StartExplode()
    {
        _bombedObjects = GameObject.FindGameObjectsWithTag("Enemy");
        var explodeList = _bombedObjects.Where(x => (x.transform.position - _playerPos.position).magnitude > _explodeDistance).ToList();
        Debug.Log(_bombedObjects.Length);
        Debug.Log(explodeList.Count);
        foreach (GameObject explode in explodeList )
        {
            explode.GetComponent<Enemy>().DamagedHp(this.gameObject);
        }
    }
}
