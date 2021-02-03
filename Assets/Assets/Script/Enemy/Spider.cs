using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }

    // Update is called once per frame
    public override void Attack()
    {
        Debug.Log("spider attack");
        
    }
}
