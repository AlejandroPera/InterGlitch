using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    float objectWidth;
    float objectHeight;
    float xcomp;
    float ycomp;


    // Start is called before the first frame update
    void Start()
    {
       
     screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
     objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
     objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y /2;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        xcomp = screenBounds.x;
        ycomp = screenBounds.y;

        //Vector3 viewPos = transform.position;
        //viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x, screenBounds.x * -1); //- objectWidth);
        //viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y, screenBounds.y * -1);//objectHeight);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xcomp, xcomp), Mathf.Clamp(transform.position.y, -ycomp, ycomp), transform.position.z);

    }
}
