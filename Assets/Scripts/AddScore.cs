using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GoldCoin")
        {
            SoundController.instance.PlayThisSound("point", 1f);

            FindObjectOfType<Score>().AddScore();
        }

        if (collision.gameObject.tag == "GoldBoss")
        {
            SoundController.instance.PlayThisSound("point", 1f);

            FindObjectOfType<Score>().AddScoreBoss();
        }
    }
    
}
