using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
   

    // Start is called before the first frame update
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
        _Movedirection = GetComponent<PlayerAnimation>();
        
       

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        
    }
    
    private void Movement() {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");
        _grounded = Isground();
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
            Debug.Log("No Flip Here");
        }else if (move < 0)
        {
            _Flip_SpriteRen.flipX = true;

        }
    } 
    public IEnumerator changjumpanim()
    {
        yield return new WaitForSeconds(1f);
        _Movedirection.Jump(false);
    }
}
