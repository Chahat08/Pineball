using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riverCloseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("TriggerManager", 0.2f);
    }

    private void TriggerManager()
    {
        gameObject.GetComponent<EdgeCollider2D>().isTrigger = false;
        Color col = new Color(255, 255, 255, 1);
        gameObject.GetComponent<SpriteRenderer>().color = col;
    }
}
