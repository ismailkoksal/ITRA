using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    public void LoadScene(Object scene)
    {
        SceneManager.LoadScene(scene.name);
    }
}
