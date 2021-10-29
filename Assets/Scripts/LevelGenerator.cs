using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject pacstudent, map;
    public GameObject[] ghosts;
         

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pacstudent, new Vector3(-13, 13, 0), Quaternion.identity);
        Instantiate(map, Vector3.zero, Quaternion.identity);

        for(int i=0; i<ghosts.Length; i++)
        {
            Instantiate(ghosts[i], new Vector3((float)i, -(float)i, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
