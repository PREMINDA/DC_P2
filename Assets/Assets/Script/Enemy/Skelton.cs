﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelton : Enemy,IDamageable
{
    public int Health { get; set; }

    public override void Init()
    {
        base.Init();
        speed = 1;
        Health = base.health;
    }

    public void Damage()
    {
        Health--;
        if(Health == 0)
        {
            Destroy(this.gameObject);
        }
    }

}
