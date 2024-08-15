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
    public Vector3 tempCoord;

    private void Start()
    {
        StartOreSpawn();
    }


    public void StartOreSpawn()
    {
        //for (int i = 0; i < smallStoneOreCount; i++)
        //{
            randomX = Random.Range(-mapSize, mapSize);
            randomY = Random.Range(-mapSize, mapSize);
            tempCoord = new Vector3(randomX, 0, randomY);

            GhostOreScript tempOre = Instantiate(ghostOre, tempCoord, Quaternion.identity).GetComponent<GhostOreScript>();

            if (tempOre.canSpawnOre)
            {
                Destroy(tempOre.gameObject);
                Instantiate(smallStoneOre, tempCoord, Quaternion.identity);
            }
            else
            {
                Destroy(tempOre.gameObject);
                //smallStoneOreCount++;
            }
        //}
    }





}
