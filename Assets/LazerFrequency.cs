using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerFrequency : MonoBehaviour
{
    bool action = true;

    public GameObject rayons;

    void Start()
    {
        StartCoroutine(lazer());
    }

    IEnumerator lazer()
    {
        Debug.Log("Début coroutine");
        while (action)
        {
            rayons.SetActive(true);
            yield return new WaitForSeconds(2);
            rayons.SetActive(false);
            yield return new WaitForSeconds(2);
        }
        
    }
}
