using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Se crea un objeto UI de Texto
//Se le agrega un script al Texto, es este

public class ScoreScript : MonoBehaviour
{
    public Camera scoreObj;
	public static int scoreValue = 0;
	Text score; 
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Aquí se sustituye la variable para tu 
        score.text = "Score: "+ AsteroidCollider.panel;  
    }
}
