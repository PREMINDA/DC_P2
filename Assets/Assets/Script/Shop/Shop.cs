using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{ 
    public GameObject shopPanal;
    private bool _isEnable;
    private Player player;
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
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
                break;
            case 1:
                UIManager.Instance.UpdateSelection(32);
                break;
            case 2:
                UIManager.Instance.UpdateSelection(-77);
                break;

        }
    }
}
