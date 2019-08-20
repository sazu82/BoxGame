using UnityEngine;
using System;


public class ItemObject : MonoBehaviour
{
	public AttachmentBase a;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Player p = other.GetComponent<Player>();

			p.RandamSet(Instantiate<AttachmentBase>(a));
			Debug.Log("触れたよ");
		}
	}
}