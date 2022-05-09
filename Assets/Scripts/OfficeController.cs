using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeController : MonoBehaviour
{
    public Animator ventAnimator;
    public Animator leftDoorAnimator;
    public Animator rightDoorAnimator;
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Display screen = Display.displays[gameObject.GetComponent<Camera>().targetDisplay];

        if(mouse.x < ((screen.systemWidth / 2) - (screen.systemWidth / 19.2)) && transform.rotation.eulerAngles.y > 70.25f){
            transform.Rotate(0, -0.25f, 0);
        } else if(mouse.x > ((screen.systemWidth / 2) + (screen.systemWidth / 19.2)) && transform.rotation.eulerAngles.y < 110f){
            transform.Rotate(0, 0.25f, 0);
        }
    }

    public void ToggleDoor(){
        if(transform.rotation.eulerAngles.y >= 70f && transform.rotation.eulerAngles.y < 85f){
            bool isClosed = leftDoorAnimator.GetBool("DoorClosed");
            leftDoorAnimator.SetBool("DoorClosed", !isClosed);
        } else if(transform.rotation.eulerAngles.y >= 85f && transform.rotation.eulerAngles.y <= 95f){
            bool isClosed = ventAnimator.GetBool("VentClosed");
            ventAnimator.SetBool("VentClosed", !isClosed);
        } else if(transform.rotation.eulerAngles.y > 95f && transform.rotation.eulerAngles.y <= 111f){
            bool isClosed = rightDoorAnimator.GetBool("DoorClosed");
            rightDoorAnimator.SetBool("DoorClosed", !isClosed);
        }
    }
}
