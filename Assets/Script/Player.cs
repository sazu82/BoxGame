using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MobBase
{
	public GameObject cameraControll;
	public GameObject coreMesh;
	public float ccx;
	public float ccy;
	public KeyCode shot = KeyCode.Space;

	// Start is called before the first frame update
	protected override void Start()
	{
		base.Start();
	}

	// Update is called once per frame
	protected override void Update()
	{
		base.Update();


		Move();

		CameraControll();
    }

	void Move()
	{
		Vector3 move = Vector3.zero;

		move.x = Input.GetAxis("Horizontal");
		move.z = Input.GetAxis("Vertical");

		move *= speed * Time.deltaTime;
		move = coreMesh.transform.TransformDirection(move);
		//move += transform.position;

		cc.Move(move);
		Gravity();
		//rigi.MovePosition(move);
	}

	void Buttle()
	{
		GameObject shot = Instantiate(shotObject,transform.position,transform.rotation);
		Rigidbody shotRig = shot.GetComponent<Rigidbody>();
		Vector3 shotPow= coreMesh.transform.TransformDirection(Vector3.forward) * pow;
		Shot s = shot.GetComponent<Shot>();
		s.parent = gameObject;

		shotRig.AddForce(shotPow);
	}

	void CameraControll()
	{
		const float max = 80, min = 280, med = 180;
		Vector3 cRot = cameraControll.transform.localRotation.eulerAngles;
		Vector3 pRot = coreMesh.transform.localRotation.eulerAngles;

		pRot.y += Input.GetAxis("Mouse X") * ccx * Time.deltaTime;
		cRot.x += Input.GetAxis("Mouse Y") * ccy * Time.deltaTime;

		if (cRot.x > max)
		{
			if (cRot.x <= min)
			{
				if (cRot.x < 180)
					cRot.x = max;
				else
					cRot.x = min;

			}
		}

		coreMesh.transform.localRotation = Quaternion.Euler(pRot);
		cameraControll.transform.localRotation = Quaternion.Euler(cRot);
	}

	public override bool File()
	{
		return Input.GetKey(shot);
	}
}
