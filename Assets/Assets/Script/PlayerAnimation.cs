using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animMove;
  

    void Start()
    {

        _animMove = GetComponentInChildren<Animator>();
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
}