using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
    GameObject panelClone;
    GameObject myPanel;
    float randomSpeed;
    float positionx;
    float positiony;
    float _random;
    public int panels_ack=0;
    public float livingTime;
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
        var position = new Vector3(positionx + 9f, Random.Range(positiony + 4.6f, positiony - 4.6f), 0);
        var finalPosition = new Vector3(positionx - 10, Random.Range(positiony + 4.8f, positiony - 4.8f), 0);
        Vector3 v3 = finalPosition - position; //Izquierda a derecha
        //Vector3 v3 = position-finalPosition; //Derecha a izquierda
        randomSpeed = Random.Range(1f, 1.5f);
        panelClone = Resources.Load("pnael") as GameObject;
        GameObject myPanel = Instantiate(panelClone, position, Quaternion.identity);

        Panel_movement move = myPanel.GetComponent<Panel_movement>();

        move.direction = v3;
        move.speed = randomSpeed;
        move.livingTime = livingTime;

        _random = Random.Range(5f, 6f);
        yield return new WaitForSeconds(_random);
        StartCoroutine("movement");
    }
}
