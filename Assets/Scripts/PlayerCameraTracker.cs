using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraTracker : MonoBehaviour
{
    public Transform playerCamera;
    public float yoffset = 5f;

    // Update is called once per frame
    void Update()
    {
        
            Vector3 newPosition = playerCamera.position;
            newPosition.y = yoffset; // Apply the offset to the current y position of the player camera
            this.transform.position = newPosition;
        }
    
}
