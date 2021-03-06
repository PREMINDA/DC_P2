﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private bool _canDamage = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable hit = collision.GetComponent<IDamageable>();
        if(hit != null && _canDamage == true)
        {
            hit.Damage();
            _canDamage = false;
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        _canDamage = true;
    }


}
