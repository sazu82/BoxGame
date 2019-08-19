using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SzUnity
{
	public class Timer
	{
		public float wait;
		public Action elapsed;

		public float now;

		public float residue
		{
			get
			{
				float res = now - Time.time + wait;
				return res < 0 ? 0 : res;
			}
		}
		public float residuePercentage
		{
			get
			{
				return residue / wait;
			}
		}
		public Timer(float wait)
		{
			this.wait = wait;
		}
		public Timer() : this(0) { }

		public void Reset()
		{
			now = Time.time;
		}
		public void Reset(float wait)
		{
			this.wait = wait;
			Reset();
		}

		public void Update()
		{
			if(wait <= Time.time - now)
			{
				elapsed();
			}
		}
	}
}
