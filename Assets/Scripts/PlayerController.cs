using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public OxygenBar oxygenManagementScript;
    public GameObject Collectable1;
    public GameObject Collectable2;
    public GameObject Collectable3;
    
    // Start is called before the first frame update
    void Start()
    {
        oxygenManagementScript = FindObjectOfType<OxygenBar>();
        Collectable1.SetActive(true);
        Collectable2.SetActive(true);
        Collectable3.SetActive(true);
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

    public void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == ("Collectable"))
        {

            Debug.Log("Picked up " + other.gameObject.name);
            if(other.gameObject.name == "chip")
            {
                Collectable1.SetActive(false);
            }
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == ("Mine"))
        {
            oxygenManagementScript.MineOxygenDecrease(50);
            Destroy(other.gameObject);
        }

    }
}
