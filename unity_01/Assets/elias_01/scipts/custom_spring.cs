using UnityEngine;
using System.Collections;

public class custom_spring : MonoBehaviour {

	//Dieses Script simuliert das verhalten einer Feder mit Dämpfung auf zwei Körper.
	//Für die enstehenden Kräfte ist es egal was Körper1 und Körper2 ist
	//Das Script wird auf den Körper gelegt, der hier Body_01 genannt wird.



	public Vector3 local_anchorpoint = Vector3.zero;
	public Vector3 local_spring_direction = Vector3.up;

	public GameObject attachment_partner;
	public Vector3 local_attachment_partner_anchorpoint = Vector3.zero;

	public float long_spring_constant = 100f; 
	public float trans_spring_constant = 1000f; 
	public float long_spring_damping = 10f; 
	public float trans_spring_damping = 100f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 global_spring_direction = transform.TransformDirection(local_spring_direction);
		Vector3 global_position_anchorpoint_01 = transform.TransformPoint(local_anchorpoint);
		Vector3 global_position_anchorpoint_02 = attachment_partner.transform.TransformPoint(local_attachment_partner_anchorpoint);
		Vector3 global_velocity_anchorpoint_01 = rigidbody.GetPointVelocity(global_position_anchorpoint_01);
		Vector3 global_velocity_anchorpoint_02 = attachment_partner.rigidbody.GetPointVelocity(global_position_anchorpoint_02);

		Vector3 position_diff = global_position_anchorpoint_02 - global_position_anchorpoint_01;
		Vector3 velocity_diff = global_velocity_anchorpoint_02 - global_velocity_anchorpoint_01;
		Vector3 position_diff_long = Vector3.Dot(global_spring_direction.normalized,position_diff)*global_spring_direction.normalized;
		Vector3 velocity_diff_long = Vector3.Dot(global_spring_direction.normalized,velocity_diff)*global_spring_direction.normalized;
		Vector3 position_diff_trans = position_diff - position_diff_long;
		Vector3 velocity_diff_trans = velocity_diff - velocity_diff_long;

		Vector3 spring_force_long = (position_diff_long - global_spring_direction)*long_spring_constant;
		Vector3 spring_force_trans = position_diff_trans*trans_spring_constant;
		Vector3 damping_force_long = velocity_diff_long*long_spring_damping;
		Vector3 damping_force_trans = velocity_diff_trans*trans_spring_damping;
		Vector3 total_spring_force = spring_force_long + spring_force_trans + damping_force_long + damping_force_trans; 

		rigidbody.AddForceAtPosition(total_spring_force,global_position_anchorpoint_01);
		attachment_partner.rigidbody.AddForceAtPosition(-total_spring_force,global_position_anchorpoint_02);
	
	}
}
