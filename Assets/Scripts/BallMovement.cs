using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float magnitude = 20f;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager.initPosition = gameObject.transform.position;
        Vector2 dir = new Vector2(0,1);
        GetComponent<Rigidbody2D>().AddForce(magnitude*dir, ForceMode2D.Impulse);
    }

    private void Update()
    {
        
    }



}
