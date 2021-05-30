using UnityEngine;

public class MoveFlowers : MonoBehaviour
{
    public float leftExtent = -2.14f;
    public float rightExtent = 1.37f;

    private char movingToward = 'r';
    private bool atEnd = false;

    public float forceMag = 10f;
    public float reboundMag = 3f;
    Vector2 dir = new Vector2(1, 0);

    Vector2 initPos;
    public float invokeAfter = 2f;

    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
        initPos = gameObject.GetComponent<Transform>().position;
    }

    void Update()
    {
        if (!atEnd)
        {
            if (Mathf.Abs(rightExtent - gameObject.transform.position.x) <= 0.2f && movingToward=='r')
                atEnd = true;

            else if (Mathf.Abs(leftExtent - gameObject.transform.position.x) <= 0.2f && movingToward=='l')
                atEnd = true;
        }
    }

    private void FixedUpdate()
    {
        if (!atEnd)
        {
            if (movingToward == 'r')
                gameObject.GetComponent<Rigidbody2D>().AddForce(forceMag * dir * Time.deltaTime, ForceMode2D.Force);
            else
                gameObject.GetComponent<Rigidbody2D>().AddForce(-forceMag * dir * Time.deltaTime, ForceMode2D.Force);
        }
        else
        {
            if (movingToward == 'r')
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(-reboundMag * dir * Time.deltaTime, ForceMode2D.Impulse);
                movingToward = 'l';
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(reboundMag * dir * Time.deltaTime, ForceMode2D.Impulse);
                movingToward = 'r';
            }

            atEnd = false;
        }
    }
   private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        Invoke("ShowAgain", invokeAfter);
    }

    private void ShowAgain()
    {
        gameObject.transform.position = initPos;
        gameObject.SetActive(true);
    }
}
