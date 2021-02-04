using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField]
    protected int health;
    [SerializeField]
    protected int speed;
    [SerializeField]
    protected int gems;
    [SerializeField]
    protected Transform pointA, pointB;

    protected Vector3 targetPos;
    protected Animator _anim;
    protected SpriteRenderer _spriteRender;

    public virtual void Init()
    {
        _anim = transform.GetChild(0).GetComponent<Animator>();
        _spriteRender = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }
    public void Start()
    {
        Init();
    }

    public virtual void Update()
    {
        if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Idal_anim"))
        {
            return;
        }
        Movement();

    }

    public virtual void Movement()
    {

        if (targetPos == pointA.position)
        {
            _spriteRender.flipX = true;
        }
        else if (targetPos == pointB.position)
        {
            _spriteRender.flipX = false;
        }
        if (transform.position == pointB.position)
        {
            targetPos = pointA.position;
            _anim.SetTrigger("Idal");
        }
        else if (transform.position == pointA.position)
        {
            targetPos = pointB.position;
            _anim.SetTrigger("Idal");
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * 2);

    }
    
    

}
