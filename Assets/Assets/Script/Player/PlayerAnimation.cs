using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animMove;
    private Animator _animarc;


    void Start()
    {

        _animMove = GetComponentInChildren<Animator>();
        _animarc = transform.GetChild(1).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       ;
    }
    public void Move(float move)

    {

        _animMove.SetFloat("Move", Mathf.Abs(move));


    }
    public void Jump(bool isjump)
    {
        _animMove.SetBool("jumping", isjump);
        Debug.Log(isjump);
    }
    public void Attack()
    {
        _animMove.SetTrigger("attack");
        Attack_Arc();
    }
    public void Attack_Arc()
    {
        _animarc.SetTrigger("arcanim");
    }
}