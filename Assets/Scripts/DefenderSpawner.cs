using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown() { 
        SpawnDefender(GetSquareClicked());
    }

    private void SpawnDefender(Vector2 coordinates)
    {
        Defender newDefender = Instantiate(defender, coordinates, UnityEngine.Quaternion.identity) as Defender;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;

    }

    private Vector2 SnapToGrid(Vector2 roundedPos)
    {
        float newX = Mathf.RoundToInt(roundedPos.x);
        float newY = Mathf.RoundToInt(roundedPos.y)+0.14f;
        return new Vector2(newX, newY);

    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }
}
