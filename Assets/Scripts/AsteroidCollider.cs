using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidCollider : MonoBehaviour
{
    private SpriteRenderer _animator;
    public Sprite exp1;
    public Sprite exp2;
    public Sprite exp3;
    public bool crash=false;
    public static int panel = 0;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (crash == true)
        {
            StartCoroutine("Animation");
        }
    }
  
    IEnumerator Animation()
    {
        _animator.sprite = exp1;
        yield return new WaitForSeconds(.3f);
        _animator.sprite = exp2;
        yield return new WaitForSeconds(.3f);
        _animator.sprite = exp3;
        _animator.enabled = false;
        yield return new WaitForSeconds(1);
        print("kpedo");
        SceneManager.LoadScene(2);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        
    }
}
