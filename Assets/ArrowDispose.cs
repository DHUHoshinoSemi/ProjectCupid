using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDispose : MonoBehaviour
{
	void Update()
	{
		if(this.transform.position.x >= Camera.main.orthographicSize * Camera.main.aspect ||
			this.transform.position.y < -Camera.main.orthographicSize)
		{
			GameObject.Destroy(this.gameObject, 0.25f);
		}
	}
}
