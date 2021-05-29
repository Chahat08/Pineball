using UnityEngine;

public class FlipperMovement2 : MonoBehaviour
{

    HingeJoint2D hinge;

    public float force = 50;
    public float minAngle = 30;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        Debug.Log(hinge.referenceAngle);
        Debug.Log(hinge.jointAngle);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("d"))
        {
            float targetForce = hinge.referenceAngle - hinge.jointAngle;
            targetForce = Mathf.Sign(targetForce) * Mathf.Max(0, Mathf.Abs(targetForce) - minAngle);

            AddTorqueAtPosition(GetComponent<Rigidbody2D>(), force * targetForce, transform.TransformPoint(hinge.anchor));
        }
    }
    public static void AddTorqueAtPosition(Rigidbody2D rb, float torque, Vector2 rotationPoint, ForceMode2D forceMode = ForceMode2D.Impulse)
    {
        rb.AddForceAtPosition(-Vector2.up * torque * rb.inertia, rotationPoint + Vector2.left, forceMode);
        rb.AddForceAtPosition(Vector2.up * torque * rb.inertia, rotationPoint - Vector2.left, forceMode);
    }

}
