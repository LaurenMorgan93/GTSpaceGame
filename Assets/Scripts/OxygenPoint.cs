using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenPoint : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player is within the oxygen point trigger
            // Call the method in OxygenBar to restore oxygen
            OxygenBar oxygenBar = FindObjectOfType<OxygenBar>();
            if (oxygenBar != null)
            {
                oxygenBar.RestoreOxyAtCheckpoint();
            }
        }
    }
}
