using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemByQTE : MonoBehaviour
{
    public RectTransform QTEimage;

    [Header("QTE范围")]
    public float QTEscope;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var scope = Mathf.Abs(QTEimage.rotation.eulerAngles.z);
            if (scope<=QTEscope)
            {
                Debug.Log("正中");
            }
            else
            {
                Debug.Log("错过");
            }
        }
    }
}
