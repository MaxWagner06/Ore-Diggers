using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GhostOreScript : MonoBehaviour
{

    public GameObject smallStone, bigStone, coal, copper, iron, silver, gold, platinum, iridium, uranium;
    [HideInInspector]public int currentOreIndex;
    [HideInInspector]public GameObject currentOreObject;
    public GameObject Ghost;
    [HideInInspector]public bool canSpawn;
    private Vector2 tempCoord;
    int randomX, randomY, MultipleX, MultipleY;

    [HideInInspector] public int mapsize, oreBetween;

    private void Start()
    {
        if(currentOreIndex == 0)
        {
            currentOreObject = smallStone;
        }
        else if(currentOreIndex == 1)
        {
            currentOreObject = bigStone;
        }
        else if (currentOreIndex == 2)
        {
            currentOreObject = coal;
        }
        else if (currentOreIndex == 3)
        {
            currentOreObject = copper;
        }
        else if (currentOreIndex == 4)
        {
            currentOreObject = iron;
        }
        else if (currentOreIndex == 5)
        {
            currentOreObject = silver;
        }
        else if (currentOreIndex == 6)
        {
            currentOreObject = gold;
        }
        else if (currentOreIndex == 7)
        {
            currentOreObject = platinum;
        }
        else if (currentOreIndex == 8)
        {
            currentOreObject = iridium;
        }
        else if (currentOreIndex == 9)
        {
            currentOreObject = uranium;
        }
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up,1f);
        if(hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Ore"))
            {
                canSpawn = false;
            }
        }
        else
        {
            canSpawn = true;
        }

        if(canSpawn)
        {
            Instantiate(currentOreObject, transform.position, Quaternion.identity);
            Destroy(gameObject);
            canSpawn = true;
        }
        else
        {
            MultipleX = Random.Range(-mapsize / oreBetween, mapsize / oreBetween);
            MultipleY = Random.Range(-mapsize / oreBetween, mapsize / oreBetween);
            randomX = MultipleX * oreBetween;
            randomY = MultipleY * oreBetween;
            tempCoord = new Vector2(randomX, randomY);

            GhostOreScript ghostOreObject = Instantiate(Ghost, tempCoord, Quaternion.identity).GetComponent<GhostOreScript>();
            ghostOreObject.currentOreIndex = this.currentOreIndex;
            Destroy(gameObject);
            canSpawn = false;
        }
    }

}
