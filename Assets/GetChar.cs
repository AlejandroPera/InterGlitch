using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChar : MonoBehaviour
{
	public Sprite N1, N2, N3, N4, N5, N6, N7, N8, N9;
	private SpriteRenderer mySprite;
    public GameObject animationSpeed;
    public GameObject animationSpeedAlt;
    public Camera myCam;

    private readonly string selectedCharacter = "SelectedCharacter";
    // Start is called before the first frame update
    public void Awake(){
        
        mySprite = this.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        int getCharacter;
        var scriptVel1 = animationSpeed.GetComponent<Speed_Back>();
        var scriptVel2 = animationSpeedAlt.GetComponent<Speed_Back>();
        var asteriods = myCam.GetComponent<Asteroid>();
        var panels = myCam.GetComponent<Panels>();

        getCharacter = PlayerPrefs.GetInt(selectedCharacter);


    switch(getCharacter)
    {
    	case 0: 
    		mySprite.sprite = N1;
            asteriods.speed = 0.5f;
            asteriods.livingTime = 12;
                panels.livingTime = 15;
            break;
    	case 1:
    		mySprite.sprite = N2;
            scriptVel1.speed = scriptVel1.speed * 1.625f;
            scriptVel2.speed = scriptVel2.speed * 1.625f;
            asteriods.speed = 0.8125f;
                asteriods.livingTime = 11;
                panels.livingTime = 15;
                break;
    	case 2:
    		mySprite.sprite = N3;
                scriptVel1.speed = scriptVel1.speed * 2;
                scriptVel2.speed = scriptVel2.speed * 2;
                asteriods.speed = 1;
                asteriods.livingTime = 10;
                panels.livingTime = 15;
                break;
    	case 3:
    		mySprite.sprite = N4;
                scriptVel1.speed = scriptVel1.speed * 2;
                scriptVel2.speed = scriptVel2.speed * 2;
                asteriods.speed = 1;
                asteriods.livingTime = 9;
                panels.livingTime = 12;
                break; 
    	case 4:
    		mySprite.sprite = N5;
                scriptVel1.speed = scriptVel1.speed * 2.3f;
                scriptVel2.speed = scriptVel2.speed * 2.3f;
                asteriods.speed = 1.15f;
                asteriods.livingTime = 9;
                panels.livingTime = 12;
                break;
    	case 5:
    		mySprite.sprite = N6;
                scriptVel1.speed = scriptVel1.speed * 3.5f;
                scriptVel2.speed = scriptVel2.speed * 3.5f;
                asteriods.speed = 1.75f;
                asteriods.livingTime = 8;
                panels.livingTime = 12;
                break;
    	case 6:
    		mySprite.sprite = N7;
                scriptVel1.speed = scriptVel1.speed * 4;
                scriptVel2.speed = scriptVel2.speed * 4;
                asteriods.speed = 2;
                asteriods.livingTime = 7;
                panels.livingTime = 7;
                break; 
    	case 7:
    		mySprite.sprite = N8;
                scriptVel1.speed = scriptVel1.speed * 4.5f;
                scriptVel2.speed = scriptVel2.speed * 4.5f;
                asteriods.speed = 2.25f;
                asteriods.livingTime =7;
                panels.livingTime = 7;
                break;
    	case 8: 
    		mySprite.sprite = N9;
                scriptVel1.speed = scriptVel1.speed * 5;
                scriptVel2.speed = scriptVel2.speed * 5;
                asteriods.speed = 2.5f;
                asteriods.livingTime = 6;
                panels.livingTime = 6;
                break;
    	default:
    		break; 
    }
}
}
