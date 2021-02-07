using System.Collections;
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
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    public override void Movement()
    {
        base.Movement();

        if (distance < 3)
        {
            
            Vector3 derection = player.transform.localPosition - this.transform.localPosition;
            
            
            if (derection.x < 0 && _anim.GetBool("InCombat") == true)
            {
                _spriteRender.flipX = true;
            }
            else if (derection.x > 0 && _anim.GetBool("InCombat") == true)
            {
                _spriteRender.flipX = false;
            }
        }

    }



    public void Damage()
    {
        Health--;
        _anim.SetTrigger("Hit");
        ishit = true;
        _anim.SetBool("InCombat", true);
        if(Health == 0 )
        {
            Destroy(this.gameObject);
            
        }
    }
    
}
