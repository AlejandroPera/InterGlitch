using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour
{
	public static int Collectibles;
    public void CollectUp()
    {
    	Collectibles++;
    	Debug.Log(string.Format("Collecionables al momento {0}", Collectibles));
    }
}


