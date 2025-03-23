using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SlingShotHandelet : MonoBehaviour
{
    private LineRenderer _leftlineRenderer;
    private LineRenderer _rightlineRenderer;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DrawSlingShot();
        }
    }

    private void DrawSlingShot()
    {
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    }
}
