using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject GoldCoin;

    [SerializeField]
    private float maxTime;

    private float timer;

    [SerializeField]
    private void Update()
    {

        if(timer > maxTime)
        {
            GameObject tmp = Instantiate(GoldCoin, new Vector3(16,Random.Range(-3, -1),0), Quaternion.identity);

            Destroy(tmp,10);

            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
