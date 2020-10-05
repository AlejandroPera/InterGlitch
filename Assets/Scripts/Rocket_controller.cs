using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_controller : MonoBehaviour
{

	public float velocity=0.5f;
	public float rotationSpeed=0.5f;
	public float horizontalMove = 0f;
	public float verticalMove = 0f;
	private new Rigidbody2D rigidbody;

	// Use this for initialization
	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		horizontalMove = Input.GetAxis("Horizontal");
		verticalMove = Input.GetAxis("Vertical");
        if (horizontalMove > 0) { 
		UpdateMoveAdaptiveRotation(horizontalMove);
		}
		Rotate(transform, verticalMove * rotationSpeed);
	}
	private void clampVelocity()
    {
		float x = Mathf.Clamp(rigidbody.velocity.x, -velocity, velocity);
		float y = Mathf.Clamp(rigidbody.velocity.y, -velocity, velocity);
		rigidbody.velocity = new Vector2(x, y);

	}
	private void UpdateMoveAdaptiveRotation(float amount)
	{

		Vector2 force = transform.up * amount;
		rigidbody.AddForce(force);
	}
	private void Rotate(Transform t, float amount)
    {
		t.Rotate(0, 0, amount);
    }
}