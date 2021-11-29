using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChangeIS : MonoBehaviour
{
    public Texture2D cursorBase;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;

    private void Start()
    {
        Cursor.SetCursor(cursorBase, hotSpot, cursorMode);
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }    void OnMouseExit()
    {
        Cursor.SetCursor(cursorBase, Vector2.zero, cursorMode);
    }
}
