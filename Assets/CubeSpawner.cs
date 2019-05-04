using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public GameObject spawnPoint;
    private int maxCubes = 10;


    private void Start()
    {
        for(int i = 0; i < maxCubes; i++)
        {
            GameObject go = Instantiate(cube, spawnPoint.transform.position, Quaternion.identity) as GameObject;
            go.AddComponent<Rigidbody>();
        }
    }

}
