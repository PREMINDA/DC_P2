﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant :Enemy,IDamageable
{
    public int Health { get; set; }
    public override void Init()
    {
        base.Init();
        Health = base.health;
    }
    public void Damage()
    {

    }
}
