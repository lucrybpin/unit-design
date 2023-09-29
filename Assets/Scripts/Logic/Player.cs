using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Character _character;

    private void Start()
    {
        _character.Move(new Vector3(1, 0, 1));
    }

    private void Update()
    {
        Vector2 mouseClickPosition;
        bool isRightClicked;

        isRightClicked = _playerInput.MouseInfo.isRightClicked;
        mouseClickPosition = _playerInput.MouseInfo.mousePosition;
        
        HandleInput(isRightClicked, mouseClickPosition);
    }

    private void HandleInput(bool isRightClicked, Vector2 mouseClickPosition)
    {
        if (!isRightClicked)
        {
            return;
        }

        Vector3 destination = Vector3.negativeInfinity;
        destination = Mouse3DPosition(mouseClickPosition);

        _character.Move(destination);
    }

    private Vector3 Mouse3DPosition(Vector3 mousePosition, Camera camera = null)
    {
        camera = (camera == null) ? Camera.main : camera;
        Ray ray = camera.ScreenPointToRay(mousePosition);
        RaycastHit hit;
        bool hitSomething = Physics.Raycast(ray, out hit, float.PositiveInfinity);
        if (hitSomething)
        {
            return hit.point;
        }
        return Vector3.negativeInfinity;
    }
}
