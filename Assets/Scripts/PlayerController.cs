using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float jumpHeight;
    
    [SerializeField]
    private GameObject GameOverObj;

    [SerializeField]
    private GameObject levelStart;

    [SerializeField]
    private Rigidbody2D rigidbody;

    private Animator anim;

   

    [SerializeField]
    private GameObject Gun;



    
    public Transform TipAttack;

   
    public GameObject Bullet;

    private bool isGround;


    [SerializeField]
    private void Awake()
    {
        Time.timeScale = 0;
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        

    }



    [SerializeField]
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround)
            {
                isGround = false;

                rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpHeight);

                SoundController.instance.PlayThisSound("Jump", 1f);

                anim.SetBool("isJumping", true);

            }
        }





        //if (Input.GetMouseButton(0))
        //{
        //    levelStart.SetActive(false);
        //    Time.timeScale = 1;
            

        //    Shot();
        //}




        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    Gun.gameObject.SetActive(true);

        //}
        //else if (Input.GetKeyDown(KeyCode.E))
        //{
        //    Gun.gameObject.SetActive(false);
        //}



    }


    [SerializeField]
    private void FixedUpdate()
    {
        


    }



    [SerializeField]
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGround = true;

            anim.SetBool("isJumping", !isGround);
        }

        if ((other.gameObject.tag == "Enemy") || (other.gameObject.tag == "Boss"))
        {
            SoundController.instance.PlayThisSound("hit", 1f);

            GameManager.instance.GameOver();
        }
        if (other.gameObject.tag == "GoldCoin")
        {

            SoundController.instance.PlayThisSound("point", 1f);

            FindObjectOfType<Score>().AddScore();
        }
    }


   

    //private void ResetGame()
    //{
    //    SceneManager.LoadScene(0);
    //}

  
    //private void GameOver()
    //{
    //    GameOverObj.SetActive(true);

    //    Destroy(gameObject);
    //    Time.timeScale = 0;
    //}





    //private void Shot()
    //{
       
    //    if (Time.time > nextTimeShot)
    //    {
    //        nextTimeShot = Time.time + shotRate;

    //        Instantiate(Bullet, TipAttack.position, Quaternion.Euler(new Vector3(0, 0, 0)));

    //        SoundController.instance.PlayThisSound("SFX_Assault Single Shot", 0.5f);
    //    }

    //}










}

