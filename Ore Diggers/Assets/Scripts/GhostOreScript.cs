using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOreScript : MonoBehaviour
{
    public bool canOreSpawn;

    private void Start()
    {
        transform.position += Vector3.left * 3f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canOreSpawn = true;
    }
}
