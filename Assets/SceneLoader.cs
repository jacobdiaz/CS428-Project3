using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string loadLevel;
    private void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene(loadLevel);
    }
}
