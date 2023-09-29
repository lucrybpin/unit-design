using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public struct MouseInfoData
    {
        public bool isLeftClicked;
        public bool isRightClicked;
        public Vector3 mousePosition;
    }

    private MouseInfoData mouseInfo;

    public MouseInfoData MouseInfo { get => mouseInfo; private set => mouseInfo = value; }

    private void Update()
    {
        mouseInfo.mousePosition = Input.mousePosition;
        mouseInfo.isLeftClicked = Input.GetMouseButtonDown(0);
        mouseInfo.isRightClicked = Input.GetMouseButtonDown(1);
    }

}
