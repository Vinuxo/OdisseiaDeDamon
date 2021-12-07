using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteracting : MonoBehaviour
{
    [SerializeField] AudioClip pickSfx;
    public bool isInteracting { get; set; }

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            isInteracting = true;
            AudioSource.PlayClipAtPoint(pickSfx, Camera.main.transform.position);
        }
        else
        {
            isInteracting = false;
        }
    }
}