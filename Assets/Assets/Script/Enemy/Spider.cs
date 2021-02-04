using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    private Vector3 targPoint;
    private Animator _anim;
    private SpriteRenderer _spiderSpriterender;

    void Start()
    {
        
        _anim = transform.GetChild(0).GetComponent<Animator>();
       
        _spiderSpriterender = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    public override void Update()
    {
        if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Spider_Idal_anim"))
        {
            return;
        }


        Movement();
       
    }
    void Movement()
    {
        if (targPoint == pointA.position)
        {
            _spiderSpriterender.flipX = true;
        }
        else if (targPoint == pointB.position)
        {
            _spiderSpriterender.flipX = false;
        }
        if (transform.position == pointB.position)
        {
            targPoint = pointA.position;
            _anim.SetTrigger("Idal");
        }
        else if (transform.position == pointA.position)
        {
            targPoint = pointB.position;
            _anim.SetTrigger("Idal");
        }
        transform.position = Vector3.MoveTowards(transform.position, targPoint, Time.deltaTime * 2);

    }
}
