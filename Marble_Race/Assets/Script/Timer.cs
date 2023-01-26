using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float time = 0;
    public bool timerIsRunning = true;
    public Text timeText;
    public static Timer instance;

    private void Start()
    {
        // Starts the timer automatically
        timeText= GameObject.Find("TimerText").GetComponent<Text>();
        timerIsRunning = true;
    }
    // utilisation de l'instance de Timer pour éviter la perte des données lors du passage des scènes grâce à "DestroyOnLoad"
    void Awake(){
        instance=this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            // DeltaTime est la différence de temps qu'il a fallu entre le moment où la deuxième image précédente s'est terminée et l'heure à laquelle l'image précédente s'est terminée.
                time += Time.deltaTime;
                DisplayTime(time, timeText);
        }
    }
    public void DisplayTime(float timeToDisplay, Text objectText)
    {
        // incrementation du temps + conversion en minute/secondes pour affichage du texte
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if(timerIsRunning==false){ // La scène Win a été chargée (Lorsque la sphère atteint l'objet avec le tag WinObject, cette valeur est mis à Faux et la scène Win est chargée)
            objectText.text = "SCORE : "+string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else{
            objectText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}