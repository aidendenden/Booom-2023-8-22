using UnityEditor;
using UnityEngine;


public class Test : MonoBehaviour
{
#if UNITY_EDITOR
    public float Distance = 25;

    public float FieldOfView = 160;

    public bool DebugFOV = true;

    private bool _isAlerted;

    private void OnDrawGizmos()
    {
        if (DebugFOV)
            drawFOV();
    }

    private void OnDrawGizmosSelected()
    {
        if (DebugFOV)
            drawFOV();
    }

    private void drawFOV()
    {
        var head = (transform.position + Vector3.up * 2);
        var angle = HorizontalAngle(transform.forward);

        var left = HorizontalVector(angle - FieldOfView * 0.5f);

        Handles.color = new Color(0.5f, 0.3f, 0.3f, 0.1f);
        Handles.DrawSolidArc(head, Vector3.up, left, FieldOfView, Distance);

        Handles.color = new Color(1, 0.3f, 0.3f, 0.75f);
        Handles.DrawWireArc(head, Vector3.up, left, FieldOfView, Distance);
        Handles.DrawLine(head, head + left * Distance);
        Handles.DrawLine(head, head + HorizontalVector(angle + FieldOfView * 0.5f) * Distance);
    }

    public static Vector3 HorizontalVector(float angle)
    {
        angle *= Mathf.Deg2Rad;
        return new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
    }

    public static float HorizontalAngle(Vector3 vector)
    {
        var v = new Vector2(vector.z, vector.x);

        if (v.sqrMagnitude > 0.01f)
            v.Normalize();

        var sign = (v.y < 0) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, v) * sign;
    }
#endif
}