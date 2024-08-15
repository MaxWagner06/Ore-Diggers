using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOreScript : MonoBehaviour
{
    public bool canOreSpawn;
    public Vector2 ghostSpawnCoord;

    private void Start()
    {
        transform.position += Vector3.left * 2f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ore")
        {
            canOreSpawn = false;
        }
        else
        {
            canOreSpawn = true;
        }
    }
}
