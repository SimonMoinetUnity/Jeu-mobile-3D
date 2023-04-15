using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class OnTrigger : MonoBehaviour
{
    public string sceneToLoad;

    public NavMeshAgent agent;

    private void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Ennemi")
        {
            transform.position = new Vector3(0f,1.39f,-9.94f);
            agent.SetDestination(new Vector3(0f,1.39f,-9.94f));
        }
        if (collider.tag == "Arrivée")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        
    }
}
