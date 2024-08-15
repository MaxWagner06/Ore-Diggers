using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOreSpawn : MonoBehaviour
{
    public GameObject smallStoneOre, bigStoneOre, coalOre, copperOre, ironOre, silverOre, goldOre,
                      platinumOre, iridiumOre, uraniumOre,ghostOre;
    public int smallStoneOreCount, bigStoneOreCount, coalOreCount, copperOreCount, ironOreCount, silverOreCount,
               goldOreCount, platinumOreCount, iridiumOreCount, uraniumOreCount;

    public int mapSize;
    private int randomX, randomY;
    private Vector2 randomCoord, ghostSpawnCoord;

    GhostOreScript ghostOreObject;



    private void Start()
    {
        StartOreSpawn();
    }

    public void StartOreSpawn()
    {

        for (int i = 0; i < smallStoneOreCount; i++)
        {
            randomX = Random.Range(-mapSize, mapSize);
            randomY = Random.Range(-mapSize, mapSize);
            randomCoord = new Vector2(randomX, randomY);
            ghostSpawnCoord = new Vector2(randomX + 4.5f, randomY);
            ghostOreObject = Instantiate(ghostOre, ghostSpawnCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            if (ghostOreObject.canSpawn)
            {
                Destroy(ghostOreObject.gameObject);
                Instantiate(smallStoneOre, randomCoord, Quaternion.identity);
            }


        }


    }

}