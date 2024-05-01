using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PLAYERMOVEMENT : MonoBehaviour
{
    private Rigidbody RB;
    public float speed = 10;
    public float jumpForce = 5;
    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float HV = Input.GetAxis("Horizontal");
        float VH = Input.GetAxis("Vertical");
        Vector3 DIR = new Vector3(HV, 0, VH);
        RB.AddForce(DIR * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump")&& canJump == true){
            RB.AddForce (Vector3.up*jumpForce, ForceMode.Impulse);
        }
       
       if (canJump == false){
        speed = 0;
       }
       else
       {
        speed = 10000f;
       }
    }
    private void OnTriggerStay(Collider other){
        canJump = true;

    } 
    private void OnTriggerExit(Collider other){
        canJump = false;

    } 
}
