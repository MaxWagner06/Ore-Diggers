using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOreSpawn : MonoBehaviour
{
    public List<Vector2> orePosList = new List<Vector2>();

    public GameObject smallStoneOre, bigStoneOre, coalOre, copperOre, ironOre, silverOre, goldOre,
                      platinumOre, iridiumOre, uraniumOre,ghostOre;
    public int smallStoneOreCount, bigStoneOreCount, coalOreCount, copperOreCount, ironOreCount, silverOreCount,
               goldOreCount, platinumOreCount, iridiumOreCount, uraniumOreCount;

    public int mapSize;
    private int randomX, randomY, randomXMultiple, randomYMultiple;
    public Vector2 randomCoord;

    private void Start()
    {
        StartOreSpawn();
    }

    public void StartOreSpawn()
    {  
    }

}