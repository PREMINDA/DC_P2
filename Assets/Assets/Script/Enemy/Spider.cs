using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy,IDamageable
{
    public int Health { get; set; }

   
    public override void Init()
    {
        base.Init();
        speed = 1;
    }
    public void Damage()
    {
        
    }

}