using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEvent : MonoBehaviour
{
    private Spider spider;

    private void Start()
    {
        spider = GameObject.FindGameObjectWithTag("Spider").GetComponent<Spider>();
    }
    public void fire()
    {
       
        spider.attack();
    }
}
