using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;
    [SerializeField] private AudioClip coinCollect;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "" + ScoreNum;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        
        Debug.Log("AAA");
        if(Coin.tag == "MyCoin")
        {
            SoundManager.instance.PlaySound(coinCollect);
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyScoreText.text = "" + ScoreNum;
        }
       
    }
}
