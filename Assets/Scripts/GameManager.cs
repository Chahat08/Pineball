using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int balls = 3;
    public Vector3 initPosition;
    public GameObject ball;
    public float invokeDelay = 2f;

    public riverCloseTrigger rct;
    public BallMovement bm;
    public TMP_Text score, ballsText, info;

    public void BallDown()
    {
        Debug.Log(initPosition);
        balls--;
        ballsText.text = "Balls: " + balls.ToString();

        if (balls == 0)
        {
            info.text = "Game Over!\nScore: " + score.text;
            Invoke("GameOver", invokeDelay);
        }
        else
        {
            info.text = "The ball went down.\nBalls Left: " + ballsText.text;
            Invoke("ResetBoard", invokeDelay);
        }
    }
    private void GameOver()
    {
        Debug.Log("Game Over!");
    }
    private void ResetBoard()
    {
        info.text = "";
        rct.UnTrigger();
        bm.resetThisStuff();
        ball.GetComponent<Transform>().position = initPosition;
    }
}
