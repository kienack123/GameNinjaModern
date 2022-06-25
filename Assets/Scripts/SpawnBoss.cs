using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Boss;

    public float maxTime;

    float timer;


    private void Update()
    {

        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(Boss, transform.position, Quaternion.identity);
            Destroy(tmp, 50);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
