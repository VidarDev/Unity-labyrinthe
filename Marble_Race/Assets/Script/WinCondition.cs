using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag.Equals("winObject"))
        {
            timer.timerIsRunning = false;
            SceneManager.LoadScene("WinScene");
        }
    }

}
