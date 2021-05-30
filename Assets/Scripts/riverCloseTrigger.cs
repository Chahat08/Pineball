using UnityEngine;

public class riverCloseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("Triggered", 0.2f);
    }

    private void Triggered()
    {
        gameObject.GetComponent<EdgeCollider2D>().isTrigger = false;
        Color col = new Color(255, 255, 255, 1);
        gameObject.GetComponent<SpriteRenderer>().color = col;
    }
    public void UnTrigger()
    {
        gameObject.GetComponent<EdgeCollider2D>().isTrigger = true;
        Color col = new Color(255, 255, 255, 0);
        gameObject.GetComponent<SpriteRenderer>().color = col;
    }
}
