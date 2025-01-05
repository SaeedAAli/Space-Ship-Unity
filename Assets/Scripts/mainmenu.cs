using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public void Loadscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}


