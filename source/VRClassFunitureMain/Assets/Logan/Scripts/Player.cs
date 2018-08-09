using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputMode
{
    NONE,
    TELEPORT,
    WALK
}

public class Player : MonoBehaviour {

    public static Player instance;

    public InputMode activeMode = InputMode.NONE;

    private void Awake()
    {
        if (instance != null)
        {
            GameObject.Destroy(instance.gameObject);
        }

        instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
