using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureButton : GazeableButton
{

    public Object prefab;

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        // Set player mode to place furniture
        Player.instance.activeMode = InputMode.FURNITURE;

        Debug.Log("Players mode has been set to FURNITURE");


        // Set active furniture prefab to this prefab
        Player.instance.activeFurniturePrefab = prefab;

        Debug.Log("Set active furniture prefab to this prefab");

    }
}
