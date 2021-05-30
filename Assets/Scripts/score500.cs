using UnityEngine;
using TMPro;

public class score500 : MonoBehaviour
{
    public TMP_Text score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.CompareTag("Player"))
        {
            int s = int.Parse(score.text);
            score.text = (s + 500).ToString();
        }
    }


}
