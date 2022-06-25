using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBoss : MonoBehaviour
{
    
    public float maxHealth;

    float currentHealth;

    public GameObject itemDrop;

    public Slider enemyHealthSlider;

    private void Awake()
    {
        currentHealth = maxHealth;
        enemyHealthSlider.maxValue = maxHealth;

        enemyHealthSlider.value = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {

    }


    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        enemyHealthSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            Dead();
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
        Instantiate(itemDrop, transform.position, Quaternion.identity);
    }
}
