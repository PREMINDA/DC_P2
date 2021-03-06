﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,IDamageable
{
    private Rigidbody2D _rg;
    [SerializeField]
    private float _jumpheight=5.0f;
    [SerializeField]
    private float _Speed = 2.5f;
    private PlayerAnimation _Movedirection;
    [SerializeField]
    private SpriteRenderer _Flip_SpriteRen;
    private bool _grounded = false;
    [SerializeField]
    private SpriteRenderer _Flip_Swordarc;
    public int Health { get; set; }
    public int _diamondcount = 0;


    // Start is called before the first frame update
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
        _Movedirection = GetComponent<PlayerAnimation>();

        Health = 8;
       

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        
    }
    public void Damage()
    {
        Debug.Log("Player get Damage()");
    }
    
    private void Movement() {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");
        _grounded = Isground();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _Movedirection.Attack();
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isground() == true)
        {
           
            _rg.velocity = new Vector2(_rg.velocity.x, _jumpheight);
            _Movedirection.Jump(true);
            StartCoroutine(changjumpanim());
            
           
        }
        Flip(Hmove);
        
        _rg.velocity = new Vector2(Hmove*_Speed, _rg.velocity.y);

        _Movedirection.Move(Hmove);

    }
   
    private bool Isground()
    {
        

        //RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, 1 << 8);
        RaycastHit2D hit=Physics2D.CircleCast(transform.position, 0.6f, Vector2.down,0.6f,1<<8);
        
        //Debug.DrawRay(transform.position, Vector3.down, Color.green);
        if (hit.collider != null)
        {
           
            return true;
        }
        return false;

    }

    public void Flip(float move)
    {
        if (move>0)
        {
            _Flip_SpriteRen.flipX = false;
            _Flip_Swordarc.flipX = false;
            _Flip_Swordarc.flipY = false;

            Vector3 newpos = _Flip_Swordarc.transform.localPosition;
            newpos.x = 0.5f;
            _Flip_Swordarc.transform.localPosition = newpos;

           
        }else if (move < 0)
        {
            _Flip_SpriteRen.flipX = true;
            _Flip_Swordarc.flipX =false;
            _Flip_Swordarc.flipY = true;
            Vector3 newpos = _Flip_Swordarc.transform.localPosition;
            newpos.x = -0.5f;
            _Flip_Swordarc.transform.localPosition = newpos;

        }
    } 
    public IEnumerator changjumpanim()
    {
        yield return new WaitForSeconds(1f);
        _Movedirection.Jump(false);
    }
    public void Collect(int dim)
    {
        _diamondcount += dim ; 
        Debug.Log("Diamond Count "  + _diamondcount );
    }

}
