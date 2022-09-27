using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    string sceneName;
    public void LoadScenario()
    {
        SceneManager.LoadScene(sceneName);
    }

}
