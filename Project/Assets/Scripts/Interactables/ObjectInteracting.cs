using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class ObjectInteracting : MonoBehaviour
{
    [SerializeField] private PlayerInteracting playerInteracting;
    [SerializeField] private UnityEvent buttonTrigger;

    private bool justDoIt;

    void Update()
    {
        if (justDoIt)
        {
            if (playerInteracting.isInteracting == true)
            {
                buttonTrigger.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        justDoIt = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        justDoIt = false;
    }
}
