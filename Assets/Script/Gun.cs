using UnityEngine;
using SzUnity;

public class Gun : AttachmentBase
{
	public Shot shot;
	public float reload;
	public float accuracy;
	public float power;
	public float bulletSpeed;
	public GameObject outObject;
	public Timer _reload;

	protected override void Start()
	{
		base.Start();

		_reload = new Timer(reload);

		_reload.elapsed = () =>
		{
			if (mobBase.File())
			{
				Fire();
				_reload.Reset(reload);
			}
		};
	}

	protected override void Update()
	{
		base.Update();
		_reload.Update();
	}

	void Fire()
	{
		GameObject shotObject = Instantiate(shot.gameObject, outObject.transform.position, outObject.transform.rotation);
		Rigidbody rigi = shotObject.GetComponent<Rigidbody>();
		Shot s = shotObject.GetComponent<Shot>();
		Vector3 shotPow = outObject.transform.TransformDirection(Vector3.back) * bulletSpeed;
		s.parent = gameObject;

		rigi.AddForce(shotPow);

	}
}



