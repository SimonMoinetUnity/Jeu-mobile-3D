using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrivée : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter(Collider collider) 
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
