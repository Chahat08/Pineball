﻿using UnityEngine;
using TMPro;

public class score30 : MonoBehaviour
{
    public TMP_Text score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int s = int.Parse(score.text);
        score.text = (s + 30).ToString();
        GetComponent<AudioSource>().Play();
    }

}
