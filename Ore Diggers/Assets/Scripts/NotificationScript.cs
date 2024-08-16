using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationScript : MonoBehaviour
{
    public float notificationDeathTime;
    private void Start()
    {
        StartCoroutine(IAmDeath());
    }
    private IEnumerator IAmDeath()
    {
        yield return new WaitForSeconds(notificationDeathTime);
        Destroy(this.gameObject);
    }
}
