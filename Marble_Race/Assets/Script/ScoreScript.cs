using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
        public Text scoreWin;

    // Start is called before the first frame update
    void Start()
    {
        scoreWin= GameObject.Find("score").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        float time=Timer.instance.time;
        Timer.instance.DisplayTime(time, scoreWin); //affichage du score
    }
}
