using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeneration : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        // Edges of the map:
        for (int i = -15; i <= 15; i++)
        {
            sideSpawn(15, i);
            sideSpawn(-15, i);
            sideSpawn(i, 15);
            sideSpawn(i, -15);
        }
        // Spawns randomized walls in map
        for (int i = 0; i < 100; i++)
        {
            spawn();
        }
    }

    void spawn()
    {
        float x = Random.Range(-14, 14);
        float y = Random.Range(-14, 14);
        GameObject newObject = Instantiate(target, new Vector3(x, y, 1), Quaternion.identity);
        newObject.GetComponent<WallGeneration>().enabled = false;
    }
    void sideSpawn(float x, float y)
    {
        GameObject newObject = Instantiate(target, new Vector3(x, y, 1), Quaternion.identity);
        newObject.GetComponent<WallGeneration>().enabled = false;
    }
}
