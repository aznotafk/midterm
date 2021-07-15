using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public AudioClip bgm;
    private AudioSource Audio;
    public void startgame(){
        SceneManager.LoadScene (sceneName:"start");
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "start")
        {
            if (Input.GetKey(KeyCode.Space)){
                SceneManager.LoadScene (sceneName:"gameplay");
            }
        }

         if (scene.name == "end")
        {
            if (Input.GetKey(KeyCode.Space)){
                SceneManager.LoadScene (sceneName:"start");
            }
        }
    }
}
