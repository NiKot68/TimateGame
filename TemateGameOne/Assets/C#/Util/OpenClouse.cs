using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClouse : MonoBehaviour
{
    public void _ClouseWindow(GameObject Window)
    {
        Window.SetActive(false);
    }
    public void _OpenWindow(GameObject Window)
    {
        Window.SetActive(true);
    }

}
