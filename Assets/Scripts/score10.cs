using UnityEngine;
using TMPro;

public class score10 : MonoBehaviour
{
    public TMP_Text score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        int s = int.Parse(score.text);
        score.text = (s + 10).ToString();
    }

}
