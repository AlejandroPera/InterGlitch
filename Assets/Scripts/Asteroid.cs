using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    GameObject asteroidClone;
    GameObject myAsteroid;
    int randomAsteroid;
    public float speed;
    public float livingTime;
    float randomSpeed;
    float positionx;
    float positiony;
    float _random;
    Vector3 position;
    Vector3 finalPosition;
    // Start is called before the first frame update

    void Start()
    {
        float positionx = this.transform.position.x;
        float positiony = this.transform.position.y;
        StartCoroutine("movement");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

     IEnumerator movement()
     {
        
        var position = new Vector3(positionx+8.6f, Random.Range(positiony + 4.6f, positiony - 4.6f), 0);
        var finalPosition = new Vector3(positionx - 10, Random.Range(positiony + 4.8f, positiony - 4.8f),0 );
        Vector3 v3 = finalPosition - position; //Izquierda a derecha
        //Vector3 v3 = position-finalPosition; //Derecha a izquierda
        randomAsteroid = Random.Range(1, 4); //Random 1-4 (3 is excluded)
        randomSpeed = Random.Range(speed, speed+1);
        asteroidClone = Resources.Load("asteroid" + randomAsteroid) as GameObject;
        GameObject myAsteroid = Instantiate(asteroidClone, position, Quaternion.identity);

        Movement move = myAsteroid.GetComponent<Movement>();

        move.direction = v3;
        move.speed = randomSpeed;
        move.livingTime = livingTime;

        _random = Random.Range(2f, 2.8f);
        yield return new WaitForSeconds(_random);
        StartCoroutine("movement");
     }
}
