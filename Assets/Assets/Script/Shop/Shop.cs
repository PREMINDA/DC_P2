using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shopPanal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                shopPanal.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                shopPanal.SetActive(false);
            }


        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            shopPanal.SetActive(false);
        }
    }
}
