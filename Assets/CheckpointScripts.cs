using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScripts : MonoBehaviour
{
    public vectorthreescriptableobject location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        location.checkpoint(this.gameObject.transform.position);
    }
}
