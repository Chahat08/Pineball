using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float rangeLow = 8f, rangeHigh = 10f;

    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(0, 2 * Mathf.PI);
        float fx = Random.Range(3,5);
        float fy = Random.Range(3,5);

        Vector2 dir = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        Vector2 mag = new Vector2(fx, fy);

        gameObject.GetComponent<Rigidbody2D>().AddForce(dir * mag, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hello");
    }


}
