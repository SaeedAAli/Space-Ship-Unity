using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class asteriodManager : MonoBehaviour
{
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0, 5);
    }
    // Update is called once per frame
   
    void SpawnAsteroid()
    {
        Instantiate(Prefab, transform.position, transform.rotation);
   
    }
}