using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreget : MonoBehaviour
{
    // Start is called before the first frame update
    private Text scoreText;
    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score = " + PlayerPrefs.GetInt("player_score");


    }
}


