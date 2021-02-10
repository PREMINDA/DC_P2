using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelton : Enemy
{
    
    
    public override void Init()
    {
        base.Init();
        speed = 1;
       
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    
}
