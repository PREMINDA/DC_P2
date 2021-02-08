using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidEffect : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Stay());
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 3);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        IDamageable hit = collision.GetComponent<IDamageable>();
        if(hit != null)
        {
            hit.Damage();
            Destroy(this.gameObject);
        }
    }
    private IEnumerator Stay()
    {
        yield return new WaitForSeconds(3f);
        if(this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
