using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    
}
