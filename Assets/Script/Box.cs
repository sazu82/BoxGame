using UnityEngine;
using System.Collections.Generic;


public class Box : AttachmentBase
{
	public List<AttachmentBase> aList;
	public AttachmentBase up;
	public AttachmentBase down;
	public AttachmentBase back;
	public AttachmentBase forward;
	public AttachmentBase left;
	public AttachmentBase right;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
		AttachmentUpdata();
	}

	public void AttachmentUpdata()
	{
		au(up, Vector3.up);
		au(down, Vector3.down);
		au(left, Vector3.left);
		au(right, Vector3.right);
		au(back, Vector3.back);
		au(forward, Vector3.forward);

	}

	void au(AttachmentBase ab, Vector3 dir)
	{

		if (ab != null)
		{
			ab.transform.parent = transform;
			ab.transform.localPosition = dir;

			//ab.transform.localRotation = Quaternion.Euler(Vector3.zero);

			if (dir == Vector3.up)
				dir = Vector3.left * 90;
			else if (dir == Vector3.down)
				dir = Vector3.left * -90;
			else if (dir == Vector3.left)
				dir = Vector3.up * -90;
			else if (dir == Vector3.right)
				dir = Vector3.up * 90;
			else if (dir == Vector3.forward)
				dir = Vector3.zero;
			else if (dir == Vector3.back)
				dir = Vector3.up * 180;
			else Debug.LogError("よくわからん値が入力されとるぞ");


			ab.transform.localRotation = Quaternion.Euler(dir);
		}
	}

}