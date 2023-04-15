using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class SceneManager2 : MonoBehaviour
{
    [SerializeField]
    private NavMeshSurface surface;

    [SerializeField]
    private Transform objectToRotate;

    void Update() 
    {
        objectToRotate.localRotation = Quaternion.Euler(new Vector3(0,15*Time.deltaTime, 0) + objectToRotate.localRotation.eulerAngles);  
        surface.BuildNavMesh();  
    }
}
