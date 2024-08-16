using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOreSpawn : MonoBehaviour
{
    public GameObject smallStoneOre, bigStoneOre, coalOre, copperOre, ironOre, silverOre, goldOre,
                      platinumOre, iridiumOre, uraniumOre,ghostOre;
    public int smallStoneOreCount, bigStoneOreCount, coalOreCount, copperOreCount, ironOreCount, silverOreCount,
               goldOreCount, platinumOreCount, iridiumOreCount, uraniumOreCount;

    public int mapSize,spaceOresBetween;
    private int randomX, randomY,multipleX,multipleY;
    private Vector2 randomCoord, ghostCoord;




    private void Start()
    {
        StartOreSpawn();
    }

    public void StartOreSpawn()
    {

        for (int i = 0; i < smallStoneOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);
            
            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 0;
        }

        for (int i = 0; i < bigStoneOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 1;
        }

        for (int i = 0; i < coalOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 2;
        }

        for (int i = 0; i < copperOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 3;
        }

        for (int i = 0; i < ironOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 4;
        }

        for (int i = 0; i < silverOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 5;
        }

        for (int i = 0; i < goldOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 6;
        }

        for (int i = 0; i < platinumOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 7;
        }

        for (int i = 0; i < iridiumOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 8;
        }

        for (int i = 0; i < uraniumOreCount; i++)
        {
            multipleX = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            multipleY = Random.Range(-mapSize / spaceOresBetween, mapSize / spaceOresBetween);
            randomX = multipleX * spaceOresBetween;
            randomY = multipleY * spaceOresBetween;
            randomCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, randomCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.mapsize = mapSize;
            ghostOreObject.oreBetween = spaceOresBetween;
            ghostOreObject.currentOreIndex = 9;
        }
    }

}