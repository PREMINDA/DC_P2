using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant :Enemy
{

    protected Vector3 targePos;
    private Animator _giantAnim;
    private bool _animswitch = false;
    private bool _giantFlip =  false;
    private SpriteRenderer _gianSpriteren;
    

    void Start()
    {
        Attack();
        targePos = pointB.position;
        _giantAnim = transform.GetChild(0).GetComponent<Animator>();
        _gianSpriteren = transform.GetChild(0).GetComponent<SpriteRenderer>();
        
        

    }

    public override void Update()
    {
        if (_animswitch == true)
        {
            _giantAnim.SetTrigger("Idal");
            StartCoroutine(stop());
        }
        else if (_animswitch == false)
        {
            Movement();
        }

    }

    void Movement()
    {
        if (transform.position == pointA.position)
        {
           
            targePos = pointB.position;
            _animswitch = true;


        }
        else if (transform.position == pointB.position)
        {
            
            targePos = pointA.position;
            _animswitch = true;

        }
        transform.position = Vector3.MoveTowards(transform.position, targePos, Time.deltaTime * 1.5f);

    }
    private IEnumerator stop()
    {
        yield return new WaitForSeconds(6f);
        _animswitch = false;
        _giantAnim.SetTrigger("walk");
        if(targePos == pointB.position)
        {
            _gianSpriteren.flipX = false;
        }
       else if(targePos == pointA.position)
        {
            _gianSpriteren.flipX = true;
        }
    }

  

}
