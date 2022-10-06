using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sphere;
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
                Instantiate(sphere, new Vector3(Random.value * 10, Random.value * 10, Random.value * 10), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
