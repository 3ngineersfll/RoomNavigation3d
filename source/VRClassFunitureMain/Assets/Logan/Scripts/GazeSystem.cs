using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeSystem : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ProcessGaze();
    }

    void OnDisable()
    {
    }

    public void ProcessGaze()
    {

        Ray raycastRay = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        Debug.DrawRay(raycastRay.origin, raycastRay.direction * 100);


        if (Physics.Raycast(raycastRay, out hitInfo))
        {

            // Do something to the object

            // Check if the object is interactable

            // Check if the object is a new object (first time looking)

            // Set the reticle color

        }

    }

    private void SetReticleColor(Color reticleColor)
    {

    }

    private void CheckForInput(RaycastHit hitInfo)
    {

        // Check for down

        // Check for hold

        // Check for release
    }
}
