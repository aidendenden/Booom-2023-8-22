using UnityEngine;

public class PressTimer : MonoBehaviour
{
    public float requiredPressDuration = 2f; // 需要按住的时间
    private bool isPressing = false; // 判断是否正在按压
    private float pressStartTime; // 按压开始时间

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPressing = true;
            pressStartTime = Time.time;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isPressing)
            {
                float pressDuration = Time.time - pressStartTime;
                if (pressDuration >= requiredPressDuration)
                {
                    // 执行按压成功的操作
                    Debug.Log("Press duration: " + pressDuration);
                }
                else
                {
                    // 执行按压时间不足的操作
                    Debug.Log("Press duration not met: " + pressDuration);
                }
            }

            isPressing = false;
        }
    }
}