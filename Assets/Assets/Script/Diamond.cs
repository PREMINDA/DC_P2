using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private Player player;
    public int gem = 1;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            player.Collect(gem);
            Destroy(this.gameObject);
        }
    }
}
