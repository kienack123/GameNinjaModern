using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    [SerializeField]
    private float aliveTime;

    [SerializeField]
    private GameObject Object;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(Object, aliveTime);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
