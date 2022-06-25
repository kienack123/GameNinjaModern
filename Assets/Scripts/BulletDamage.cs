using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{




    public float weaponDamage;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyHealth hurtEnemy = other.gameObject.GetComponent<EnemyHealth>();

            hurtEnemy.AddDamage(weaponDamage);

            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Boss")
        {
            HealthBoss hurtEnemy = other.gameObject.GetComponent<HealthBoss>();

            hurtEnemy.AddDamage(weaponDamage);

            Destroy(gameObject);
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyHealth hurtEnemy = other.gameObject.GetComponent<EnemyHealth>();

            hurtEnemy.AddDamage(weaponDamage);

            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Boss")
        {
            HealthBoss hurtBoss = other.gameObject.GetComponent<HealthBoss>();

            hurtBoss.AddDamage(weaponDamage);

            Destroy(gameObject);
        }
    }
}
