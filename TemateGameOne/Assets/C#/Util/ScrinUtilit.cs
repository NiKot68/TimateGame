using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class ScrinUtilit : MonoBehaviour
{
    [SerializeField, Header("Вкл/Выкл")]private bool IsActive;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && IsActive == true)
        {
            int Ran = Random.Range(0, 10000);
            ScreenCapture.CaptureScreenshot("screenshot" + Ran + ".png");
        }
    }

}
