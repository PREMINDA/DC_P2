using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant :Enemy
{

    protected Vector3 targePos;
    [SerializeField]

    void Start()
    {
        Attack();
        targePos = pointB.position;
        
    }

    public override void Update()
    {
        
        
        if(transform.position == pointA.position)
        {
            targePos = pointB.position;
        }else if (transform.position == pointB.position)
        {
            targePos = pointA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, targePos, Time.deltaTime * 3);

    }

  

}
