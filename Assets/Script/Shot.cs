
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Shot : MonoBehaviour
{
	public int fireRate = 1;
	public int damage = 1;
	public GameObject parent;

	private void OnTriggerEnter(Collider other)
	{
		GameObject target = other.gameObject;

		if (other.tag == "Attachment")
		{
			AttachmentBase a = other.GetComponent<AttachmentBase>();

			target = a.parent.gameObject;
			if (target.tag == "Enemy")
			{
				MobBase mob = other.GetComponent<MobBase>();
				mob.Damage(damage);

			}

			if (target.tag != "Player")
			{
				Destroy(gameObject);
			}
		}

		if (other.tag == "Enemy")
		{
			MobBase mob = other.GetComponent<MobBase>();
			mob.Damage(damage);

		}

		if (other.tag != "Player")
		{
			Destroy(gameObject);
		}

	}
}
