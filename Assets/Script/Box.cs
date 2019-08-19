using UnityEngine;


public class Box : AttachmentBase
{
	public AttachmentBase up;
	public AttachmentBase down;
	public AttachmentBase back;
	public AttachmentBase forword;
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
		if (up != null)
		{
			up.transform.localPosition = Vector3.up;
			up.transform.localRotation = Quaternion.Euler(Vector3.zero);
		}

		if (down != null)
		{
			down.transform.localPosition = Vector3.down;
			down.transform.localRotation = Quaternion.Euler(Vector3.zero);
		}

		if (back != null)
		{
			back.transform.localPosition = Vector3.back;
			back.transform.localRotation = Quaternion.Euler(Vector3.zero);
		}

		if (forword != null)
		{
			forword.transform.localPosition = Vector3.forward;
			forword.transform.localRotation = Quaternion.Euler(Vector3.zero);
		}

		if (left != null)
		{
			left.transform.localPosition = Vector3.left;
			left.transform.localRotation = Quaternion.Euler(Vector3.zero);
		}

		if (right != null)
		{
			right.transform.localPosition = Vector3.right;
			right.transform.localRotation = Quaternion.Euler(Vector3.zero);
		}
	}

}