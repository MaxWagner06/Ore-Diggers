using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOreScript : MonoBehaviour
{
    public bool canSpawnOre;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ore"||collision.gameObject.tag == "Player")
        {
            canSpawnOre = false;
        }
        if(collision.gameObject == null)
        {
            canSpawnOre = true;
        }
    }
}
