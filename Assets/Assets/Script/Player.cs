using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rg;
    [SerializeField]
    private float _jumpheight=5.0f;
    private bool _isground = true;
    private bool _re_jump = false;
    // Start is called before the first frame update
    void Start()
    {
        _rg = gameObject.GetComponent<Rigidbody2D>();
       

    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.Space) && _isground == true)
        {
            _rg.velocity = new Vector2(_rg.velocity.x, _jumpheight);
            _isground = false;
            _re_jump = true;
            StartCoroutine(wait());
        }

        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position,Vector2.down,1.0f,1<<8);
        if(hitinfo.collider != null)
        {
            if(_re_jump == false) { 
            _isground = true;
            }
        }
            _rg.velocity = new Vector2(Hmove, _rg.velocity.y);
        
        
    }
    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(0.1f);
        _re_jump = false;
        

    }
}
