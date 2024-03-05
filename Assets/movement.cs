using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum speeds {slow = 0, normal = 1, fast = 2, faster = 3, fastest = 4};
public class movement : MonoBehaviour
{
    public speeds CurrentSpeed;
    float[] speedvalues = { 8.7f, 10.4f, 12.96f, 15.6f, 19, 27f };

    public Transform GroundCheckTransform;
    public float GroundCheckRadius;
    public LayerMask GroundMask;

    void Update()
    {
        transform.position += Vector3.right * speedvalues[(int)CurrentSpeed] * Time.deltaTime;

        if(Input.GetMouseButton(0))
        {
            // jump
        }
    }

    bool OnGround()
    {
        return Physics2D.OverlapCircle(GroundCheckTransform.position, GroundCheckRadius, GroundMask);
    }
}