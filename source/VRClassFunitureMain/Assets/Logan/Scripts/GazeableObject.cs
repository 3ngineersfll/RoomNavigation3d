using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeableObject : MonoBehaviour
{

    public bool isTransformable = false;

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
    }

    public virtual void GazeTransform(RaycastHit hitInfo)
    {

        // Call the correct transformation function

        switch (Player.instance.activeMode)
        {

            // Call differnet cases for active mode
            case InputMode.TRANSLATE:
                GazeTranslate(hitInfo);
                break;

            case InputMode.ROTATE:
                GazeTranslate(hitInfo);
                break;

            case InputMode.SCALE:
                GazeTranslate(hitInfo);
                break;

        }

    }

    public virtual void GazeTranslate(RaycastHit hitInfo)
    {

        // Move the object (position)

    }

    public virtual void GazeRotate(RaycastHit hitInfo)
    {

        // Change the object's orentation (rotation)

    }

    public virtual void GazeScale(RaycastHit hitInfo)
    {

        // Make the object bigger/smaller (scale)

    }

}
