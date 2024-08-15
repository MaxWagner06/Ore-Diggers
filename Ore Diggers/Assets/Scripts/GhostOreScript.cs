using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOreScript : MonoBehaviour
{
    public bool canSpawn = true;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-5, 0);
        StartCoroutine(Wait());

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(1f);
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Ore")
        {
            canSpawn = false;
        }
    }


}
