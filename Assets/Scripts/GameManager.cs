using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public GameObject GameOverObj;

    public GameObject Player;

    [SerializeField] private AudioSource AudioBackground;

    public static GameManager instance { get; set; }
    private void Awake()
    {
        instance = this;
    }


    //public void ResetGame()
    //{
    //    SceneManage
    //}
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        GameOverObj.SetActive(true);

        Destroy(Player);
        Time.timeScale = 0;

    }


    public void turnOffSound()
    {
        AudioBackground.gameObject.SetActive(false);
    }
}
