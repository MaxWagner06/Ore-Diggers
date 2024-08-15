using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleScripts : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * 3f;
        }
    }
}
