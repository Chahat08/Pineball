using UnityEngine;
using TMPro;

public class score1000 : MonoBehaviour
{
    public TMP_Text score;

    public void AddScore()
    {
        int s = int.Parse(score.text);
        score.text = (s + 1000).ToString();
    }
}
