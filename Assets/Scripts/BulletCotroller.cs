using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCotroller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speedBullet;
    [SerializeField]
  

    private void Update()
    {
        transform.position += Vector3.right * speedBullet * Time.deltaTime;

    }

}
