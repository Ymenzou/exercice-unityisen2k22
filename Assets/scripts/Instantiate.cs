using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Sphere;
    [SerializeField] private Transform spawnPoint; 

    void Start()
    {
        Instantiate(Sphere, spawnPoint.position, spawnPoint.rotation); 
    }

    void Update()
    {
        
    }
}
