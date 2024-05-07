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
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;
        camForward.y = 0;
        camRight.y = 0;
        float HV = Input.GetAxis("Horizontal");
        float VH = Input.GetAxis("Vertical");
        Vector3 forwardRelative = VH * camForward;
        Vector3 rightRelative = HV * camRight;
        Vector3 DIR = forwardRelative + rightRelative;
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
