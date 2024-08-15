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
    public Vector2 tempCoord;
    public Vector2 tempCoordGhost;

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
            tempCoord = new Vector2(randomX, randomY);
            tempCoordGhost = new Vector2(randomX + 2, randomY);

            GhostOreScript ghostOreObject = Instantiate(ghostOre, tempCoordGhost, Quaternion.identity).GetComponent<GhostOreScript>();

            if (ghostOreObject.canOreSpawn)
            {
                Destroy(ghostOreObject.gameObject);
                Instantiate(smallStoneOre, tempCoord, Quaternion.identity);
            }
            else
            {
                
            }
        }
        
    }

}






