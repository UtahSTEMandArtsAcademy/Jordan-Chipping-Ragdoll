using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DEATH : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        Destroy(other.gameObject);
    }
}
