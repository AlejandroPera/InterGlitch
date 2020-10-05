using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var script = collision.gameObject.GetComponent<AsteroidCollider>();
        if (script != null)
        {
            Destroy(gameObject);
            AsteroidCollider.panel+=1;
        }
    }
}
