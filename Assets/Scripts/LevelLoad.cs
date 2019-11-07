using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    //zmienna - ile czasu czekać
    [SerializeField] int timeToWait = 3;

    //numer aktualnej sceny
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        //wybiera z SceneManagera aktualnie włączoną scene
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        //jeżeli włączona scena to scena 0 (Splash Screen)
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }

    }

    //Coroutine - WaitForTime function
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);

        //załadowanie kolejnej sceny
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
