using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCity : MonoBehaviour
{
    public GameObject[] buildings;
    // Smaller map size for testing 
    public int mapWidth = 20;
    public int mapHeight = 20;
    int buildingFootprint = 3;

    // Start is called before the first frame update
    void Start()
    {
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                float seed = 55; // Random.Range(0, 100);
                int result = (int)(Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 10);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                if (result < 2)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if (result < 4)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if (result < 6)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if (result < 8)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if (result < 10)
                    Instantiate(buildings[4], pos, Quaternion.identity);
            }
        }
    }

}
