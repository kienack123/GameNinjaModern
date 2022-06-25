using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int score;

    [SerializeField]
    private Text text;

    [SerializeField]
    public void AddScore()
    {
        score = score + 100;
        text.text = score.ToString();
    }


    public void AddScoreBoss()
    {
        score = score + 1000;
        text.text = score.ToString();
    }


}
