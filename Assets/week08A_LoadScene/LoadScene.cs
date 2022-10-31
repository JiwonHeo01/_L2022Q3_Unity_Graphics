using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    Scene CurrentScene;

    void Start()
    {
        CurrentScene = gameObject.scene;
        print(CurrentScene.name);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("LoadSceneTest02");
    }
}
