using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOreScript : MonoBehaviour
{
    public bool canSpawnOre;
    public string selam = "YOKYOKyoK";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ore")
        {
            selam = "Maden Var amk";
        }
    }
}
