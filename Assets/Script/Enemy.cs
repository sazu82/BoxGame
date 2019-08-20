using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class Enemy : MobBase
{
	public List<List<EnemyMove>> NormalMoves;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}



	//通常時
	public void Normal()
	{
		
	}

	//攻撃時
	public void Rage()
	{

	}

	//遠距離

}
