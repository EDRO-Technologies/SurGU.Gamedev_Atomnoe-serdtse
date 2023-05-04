using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDoor : MonoBehaviour
{
    public GameObject[] firstGroup;
    public WoodDoor key;
    public Material keyNormal;
    public Material keyTransparent;
    public Material doorNormal;
    public Material doorTransparent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = doorTransparent;
                first.GetComponent<Collider>().isTrigger = true;
            }

            GetComponent<Renderer>().material = doorTransparent;
            key.GetComponent<Renderer>().material = keyTransparent;
        }
    }
}