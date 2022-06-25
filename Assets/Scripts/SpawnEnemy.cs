using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Enemy;

    [SerializeField]
    private float maxTime;

    private float timer;


    private void Update()
    {

        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(Enemy, transform.position, Quaternion.identity);

            Destroy(tmp, 10);

            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
