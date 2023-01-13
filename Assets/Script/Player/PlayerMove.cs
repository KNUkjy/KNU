using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float h = 0.0f;
    public float v = 0.0f;
    public float x = 0.0f;
    public float y = 0.0f;
    public GameObject KiKi;
    public Animator runAnim;
    private Transform tr;
    public float moveSpeed = 0.7f;
    public float rotSpeed = 40.0f;
    

    public void Playermove()
    {
        Vector3 dir = (Vector3.right * h) + (Vector3.forward * v);
        if (dir.sqrMagnitude > (1.0f * 1.0f)) dir = dir.normalized;
        tr.Translate(dir * moveSpeed * Time.deltaTime, Space.Self);
        tr.Rotate(Vector3.up * x * rotSpeed * Time.deltaTime);
        
        
    }

    public void PlayerAnim()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            runAnim.SetBool("RunBool", true);

        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            runAnim.SetBool("RunBool", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            runAnim.SetBool("RunBool", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            runAnim.SetBool("RunBool", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            runAnim.SetBool("RunBool", true);

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            runAnim.SetBool("RunBool", false);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            runAnim.SetBool("RunBool", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            runAnim.SetBool("RunBool", false);
        }
    }
    void Start()
    {
        tr = this.gameObject.GetComponent<Transform>();
        runAnim = KiKi.GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Confined;

    }


    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        x = Input.GetAxis("Mouse X");


        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        Playermove();
        PlayerAnim();
    }
    } 


