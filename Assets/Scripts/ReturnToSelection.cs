using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReturnToSelection : MonoBehaviour
{
    int delay;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine("BackToSelection");
    }

    IEnumerator BackToSelection()
    {
        delay = 3;
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0);
    }
}
