using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public OxygenBar oxygenManagementScript;
    // Start is called before the first frame update
    void Start()
    {
        oxygenManagementScript = FindObjectOfType<OxygenBar>();
    }


    public void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == ("SafeZone"))
        {
            Debug.Log(other.gameObject.tag);
            oxygenManagementScript.InSafeZone = true;
            

        }

    }

    public void OnTriggerExit (Collider other)
    {
        if(other.gameObject.tag == ("SafeZone"))
        {
            
            oxygenManagementScript.InSafeZone = false;
            
        }
    }
}
