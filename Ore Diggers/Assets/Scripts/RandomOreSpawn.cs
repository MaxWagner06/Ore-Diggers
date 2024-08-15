using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOreSpawn : MonoBehaviour
{
    public GameObject smallStoneOre, bigStoneOre, coalOre, copperOre, ironOre, silverOre, goldOre,
                      platinumOre, iridiumOre, uraniumOre,ghostOre;
    public int smallStoneOreCount, bigStoneOreCount, coalOreCount, copperOreCount, ironOreCount, silverOreCount,
               goldOreCount, platinumOreCount, iridiumOreount, uraniumOreCount;

    public int mapSize;
    private int randomX, randomY;
    private int rayPositionZ = -10;
    public Vector2 tempCoord;
    public Vector3 rayCoord;

    private void Start()
    {
        StartOreSpawn();
    }


    public void StartOreSpawn()
    {
        randomX = Random.Range(-mapSize, mapSize);
        randomY = Random.Range(-mapSize, mapSize);
        tempCoord = new Vector2(randomX, randomY);

        for (int i = 0; i < smallStoneOreCount; i++)
        {
            rayCoord = new Vector3(randomX, rayPositionZ, randomY);
            RaycastHit hit;
            if (Physics.Raycast(rayCoord, Vector3.forward, out hit, Mathf.Infinity))
            {
                if (!hit.collider)
                {
                    Instantiate(smallStoneOre, tempCoord, Quaternion.identity);
                }
                else
                {
                    smallStoneOreCount++;
                }
            }

        }
    }

}






