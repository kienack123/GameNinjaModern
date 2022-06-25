using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField]
    private float speed;


    [SerializeField] public GameObject hitEffect;

    public GameObject itemDrop;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

            Destroy(effect, 0.2f);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

            Destroy(effect, 0.2f);
        }
    }
}
