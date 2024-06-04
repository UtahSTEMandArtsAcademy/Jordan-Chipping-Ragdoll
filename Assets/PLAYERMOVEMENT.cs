using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYERMOVEMENT : MonoBehaviour
{
    private Rigidbody RB;
    public float speed = 10;
    public float jumpForce = 5;
    public bool canJump;
    public Transform cam;
    public vectorthreescriptableobject loca;
    public vectorthreescriptableobject death_height;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        transform.position = loca.location;
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
        speed = 5000;
       }
       else
       {
        speed = 10000f;
       }

        if(transform.position.y < death_height.location.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            loca.location = new Vector3(8.04f, 0.41f, -11.19f);
        }
    }
    private void OnTriggerStay(Collider other){
        canJump = true;

    } 
    private void OnTriggerExit(Collider other){
        canJump = false;

    } 

}
