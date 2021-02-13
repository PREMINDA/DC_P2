using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{ 
    public GameObject shopPanal;
    private bool _isEnable;
    private Player player;
    private int selectitem;

    Dictionary<int, int> listitem;


public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
       listitem = new Dictionary<int, int>()
        {
            {0,200 },
            {1,100 },
            {2,400 }
        };

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isEnable == true)
        {
            
            shopPanal.SetActive(true);
            UIManager.Instance.Openshop(player._diamondcount);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _isEnable == true)
        {
            shopPanal.SetActive(false);
        }
    } 
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {

            _isEnable = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _isEnable = false;
        }
    }
    public void SelectItem(int item)
    {
        
        switch (item)
        {
            case 0:
                UIManager.Instance.UpdateSelection(129);
                selectitem = item;
                break;
            case 1:
                UIManager.Instance.UpdateSelection(32);
                selectitem = item;
                break;
            case 2:
                UIManager.Instance.UpdateSelection(-77);
                selectitem = item;
                break;

        }
    }

    public void BuyItem()
    {
        if (player._diamondcount >= listitem[selectitem])
        {
            player._diamondcount = player._diamondcount - listitem[selectitem];
            UIManager.Instance.Openshop(player._diamondcount);
        }
    }
}
