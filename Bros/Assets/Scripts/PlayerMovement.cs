using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

public float MoveSpeed = 10;
//public float RotateSpeed = 40;
	
bool Grounded = false;

void Start()
{
}
// Update is called once per frame

void Update () 
{
    // Amount to Move
    float MoveForward = Input.GetAxis("Horizontal")  * MoveSpeed * Time.deltaTime;
    //float MoveRotate = Input.GetAxis("Vertical") * RotateSpeed * Time.deltaTime;


    // Move the player
    transform.Translate(Vector3.forward * MoveForward);
    //transform.Rotate(Vector3.up * MoveRotate);
		
	if (Input.GetButtonDown("Jump") && Grounded == true)
       {
         Jump();
       }   	
}
	
void Jump ()
	{
		 rigidbody.AddForce (Vector3.up * 400);
	}
void OnCollisionExit(Collision OtherObject)
	{
		if (OtherObject.gameObject.tag == "Ground")
			Grounded = false;
	}
void OnCollisionEnter (Collision OtherObject)
	{
		if (OtherObject.gameObject.tag == "Ground")
			Grounded = true;
	}

}