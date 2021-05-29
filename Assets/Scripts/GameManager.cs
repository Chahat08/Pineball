using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int balls = 3;
    public Vector3 initPosition;

    public void BallDown()
    {
        Debug.Log(initPosition);
        balls--;
        if(balls==0)
        {
            GameOver();
        }
    }
    private void GameOver()
    {
        Debug.Log("game over!");
    }
}
