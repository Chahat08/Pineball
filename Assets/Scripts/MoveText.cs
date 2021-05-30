using UnityEngine;

public class MoveText : MonoBehaviour
{
    public GameObject flowers;
    public float x = 0.5f, y = 0.5f;

    private void Update()
    {
        Vector3 v = new Vector3(x, y, 0);
        gameObject.GetComponent<Transform>().position = flowers.GetComponent<Transform>().position + v ;
    }
    public void disappear()
    {
        gameObject.SetActive(false);
    }
    public void reappear()
    {
        gameObject.SetActive(true);
        gameObject.GetComponent<Transform>().position = flowers.GetComponent<Transform>().position;
    }
}
