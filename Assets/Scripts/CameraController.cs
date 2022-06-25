using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float smoothing;

    Vector3 offset;

    private float lowY;

    private void Start()
    {
        offset = transform.position - target.position;

        lowY = transform.position.y;

       
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 targetCampos = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetCampos, smoothing * Time.deltaTime);

        if (transform.position.y < lowY )
        {
            transform.position = new Vector3(transform.position.x, lowY, transform.position.z);    
        }
        
    }
}
