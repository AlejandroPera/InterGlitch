using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var script = collision.gameObject.GetComponent<AsteroidCollider>();
        if (script != null)
        {
            Destroy(gameObject);
            script.crash = true;
        }
    }
}
