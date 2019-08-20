using UnityEngine;

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
		
	}
}