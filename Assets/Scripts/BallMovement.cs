using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float minMag = 20f;
    public float maxMag = 30f;
    public GameManager manager;

    private float keyTime = 0f;
    private bool keyUp = false;
    private bool launched = false;

    private void Update()
    {
        if (!keyUp) { manager.initPosition = gameObject.transform.position; keyHeldDownTime(); }

        else if (!launched)
        {
            Vector2 dir = new Vector2(0, 1);

            float mag = (keyTime + 3 + minMag);
            Debug.Log(mag);

            //if (mag < minMag) mag = minMag;
            if (mag > maxMag) mag = maxMag;

            GetComponent<Rigidbody2D>().AddForce(mag * dir, ForceMode2D.Impulse);
            launched = true;
        }

        else if (launched && gameObject.GetComponent<Rigidbody2D>().velocity.magnitude == 0)
        {
            Vector2 dir = new Vector2(Mathf.Cos(Random.Range(0, 2 * Mathf.PI)), Mathf.Sin(2 * Mathf.PI));
            gameObject.GetComponent<Rigidbody2D>().AddForce(dir * 10, ForceMode2D.Impulse);
        }
    }

    private void keyHeldDownTime()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            keyTime = Time.time;
        }
        if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.Space))
        {
            keyUp = true;
            keyTime = Time.time - keyTime;
        }
    }

    public void resetThisStuff()
    {
        
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        keyTime = 0;
        keyUp = false;
        launched = false;
    }

    

}
