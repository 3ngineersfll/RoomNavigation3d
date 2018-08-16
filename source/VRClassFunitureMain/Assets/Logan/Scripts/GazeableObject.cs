using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeableObject : MonoBehaviour
{

    public bool isTransformable = false;

    private int objectLayer;
    private const int IGNORE_REYCAST_LAYER = 2;

    public virtual void OnGazeEnter(RaycastHit hitInfo)
    {
        Debug.Log("Gaze entered on " + gameObject.name);
    }

    public virtual void OnGaze(RaycastHit hitInfo)
    {
        Debug.Log("Gaze hold on" + gameObject.name);
    }

    public virtual void OnGazeExit()
    {
        Debug.Log("Gaze exited on" + gameObject.name);
    }

    public virtual void OnPress(RaycastHit hitInfo)
    {
        Debug.Log("Button pressed");

        if (isTransformable)
        {

            objectLayer = gameObject.layer;
            
            gameObject.layer = IGNORE_REYCAST_LAYER;

        }

    }

    public virtual void OnHold(RaycastHit hitInfo)
    {
        Debug.Log("Button hold");

        if (isTransformable)
        {
            GazeTransform(hitInfo);
        }
    }

    public virtual void OnRelease(RaycastHit hitInfo)
    {
        Debug.Log("Button release");

        if (isTransformable)
        {

            gameObject.layer = objectLayer;

        }

    }

    public virtual void GazeTransform(RaycastHit hitInfo)
    {

        // Call the correct transformation function

        switch (Player.instance.activeMode)
        {

            // Call differnet case for active mode
            case InputMode.TRANSLATE:
                GazeTranslate(hitInfo);
                break;

            case InputMode.ROTATE:
                GazeRotate(hitInfo);
                break;

            case InputMode.SCALE:
                GazeScale(hitInfo);
                break;

        }

    }

    public virtual void GazeTranslate(RaycastHit hitInfo)
    {
        Debug.Log("Button Translate");

        // Move the object (position)

        if (hitInfo.collider != null && hitInfo.collider.GetComponent<Floor>())
        {

            transform.position = hitInfo.point;

        }

    }

    public virtual void GazeRotate(RaycastHit hitInfo)
    {

        // Change the object's orientation (rotation)

    }

    public virtual void GazeScale(RaycastHit hitInfo)
    {

        // Make the object bigger/smaller (scale)

    }

}


