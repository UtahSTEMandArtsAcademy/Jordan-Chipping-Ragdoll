using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DEATH : MonoBehaviour
{
    public GameObject particle;
    void OnTriggerEnter(Collider other)
    {
        GameObject clone;
        clone = Instantiate(particle, other.gameObject.transform.position, other.gameObject.transform.rotation);
        Destroy(other.gameObject);
        Destroy(clone, 3f);

    }
}
