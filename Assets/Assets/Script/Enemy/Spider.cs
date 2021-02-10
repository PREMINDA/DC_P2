using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    [SerializeField]
    private GameObject _acidPrefab;

    //public override void Init()
    //{
    //    base.Init();
    //    speed = 1;
    //}
    public override void Movement()
    {
        
    }

    public void attack()
    {
        Instantiate(_acidPrefab, new Vector3(transform.position.x-0.6f, transform.position.y-0.1f + 0), Quaternion.identity);

    }
}