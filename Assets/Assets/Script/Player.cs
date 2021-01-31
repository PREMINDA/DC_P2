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
    
    // Start is called before the first frame update
    void Start()
    {
        _rg = gameObject.GetComponent<Rigidbody2D>();
        _Movedirection = transform.GetComponent<PlayerAnimation>();
       

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        
        
        
    }
    
    private void Movement() {

        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && Isground() == true)
        {
            _rg.velocity = new Vector2(_rg.velocity.x, _jumpheight);
            
           
        }
        
        _rg.velocity = new Vector2(Hmove*_Speed, _rg.velocity.y);
        _Movedirection.Move(Hmove);

    }
   
    private bool Isground()
    {

        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, 1 << 8);
        if (hitinfo.collider != null)
        {
            return true;
        }
        return false;

    }
}
