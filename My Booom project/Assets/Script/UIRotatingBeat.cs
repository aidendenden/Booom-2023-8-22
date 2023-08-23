using UnityEngine;

public class UIRotatingBeat : MonoBehaviour
{
    public float rotationSpeed = 100f;   // 旋转速度
    public float rotationAmplitude = 30f;   // 旋转振幅

    private RectTransform rectTransform;
    private float initialRotation;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        initialRotation = rectTransform.rotation.eulerAngles.z;
    }

    private void Update()
    {
        // 计算旋转角度
        float rotationAngle = initialRotation + Mathf.Sin(Time.time * rotationSpeed) * rotationAmplitude;

        // 应用旋转角度
        rectTransform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
    }
}