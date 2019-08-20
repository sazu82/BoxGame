using UnityEngine;
using System.Collections.Generic;

public class MobBase : MonoBehaviour
{
	static public float gravity = 6;

	protected CharacterController cc;

	public GameObject coreBox;
	public GameObject shotObject;
	public float pow = 1;
	public float speed = 1;
	public float life = 1;

	protected virtual void Start()
	{
		cc = GetComponent<CharacterController>();
	}

	protected virtual void Update()
	{
		Des();
	}

	void Des()
	{
		if (life <= 0)
		{
			Destroy(gameObject);
		}
	}

	protected void Gravity()
	{
		Vector3 g = Vector3.down * gravity * Time.deltaTime;

		cc.Move(g);
	}

	public void Damage(int damage)
	{
		life -= damage;
	}

	public virtual bool File()
	{
		return true;
	}

	public void RandamSet(AttachmentBase attachment)
	{
		bool check = false, s = false;
		Box box = coreBox.GetComponent<Box>();
		List<Box> boxes = new List<Box>();

		while (true)
		{
			for (int i = 0; i < box.aList.Length; i++)
			{
				if (box.aList[i] == null)
				{
					box.aList[i] = attachment;
					box.ListUpdata();

					return;
				}
				else if (box.aList[i] is Box)
				{
					boxes.Add((Box)box.aList[i]);
				}
			}

			box = boxes[0];
			boxes.Remove(boxes[0]);

		}
	}
}