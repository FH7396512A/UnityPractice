using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;
    public void OnUpdate() //입력된게 있으면 실행
    {
        if(Input.anyKey == false)
        {
            return;
        }
        if(KeyAction != null)
        {
            KeyAction.Invoke();
        }
    }
}
