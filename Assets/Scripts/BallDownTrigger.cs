using UnityEngine;

public class BallDownTrigger : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager.BallDown();
    }
}
