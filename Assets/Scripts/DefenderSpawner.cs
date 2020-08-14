using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown() { 
        SpawnDefender(GetSquareClicked());
    }

    private void SpawnDefender(Vector2 coordinates)
    {
        GameObject newDefender = Instantiate(defender, coordinates, UnityEngine.Quaternion.identity) as GameObject;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;

    }
}
