using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private Transform tipAttack;

    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject[] ammo;

    private int ammoAmount;


    private float shotRate = 0.2f;

    private float nextTimeShot = 0;

    public GameObject levelStart;

    private void Awake()
    {
        ammoAmount = 20;
        for (int i = 0; i < ammoAmount; i++)
        {
            ammo[i].gameObject.SetActive(true);
        }
    

    }

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            levelStart.SetActive(false);
            Time.timeScale = 1;

            Shot();

           
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            
            ReloadBullet();

        }    

    }
    void Shot()
    {

        if ((Time.time > nextTimeShot) && (ammoAmount > 0))
        {
            nextTimeShot = Time.time + shotRate;

            var spawnBullet = Instantiate(bullet, tipAttack.position, Quaternion.Euler(new Vector3(0, 0, 0)));

            SoundController.instance.PlayThisSound("fire", 0.5f);

            ammoAmount -= 1;

            ammo[ammoAmount].gameObject.SetActive(false);
        }
        else if ((Time.time > nextTimeShot) && (ammoAmount <= 0))
        {
            nextTimeShot = Time.time + shotRate;
            SoundController.instance.PlayThisSound("gunDryOut", 1f);

        }



    }


    void ReloadBullet()
    {
        ammoAmount = 20;
        for (int i = 0; i < ammoAmount; i++)
        {
            ammo[i].gameObject.SetActive(true);
        }
        SoundController.instance.PlayThisSound("reloadBullet", 1f);
    }
}

