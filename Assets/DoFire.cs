using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoFire : MonoBehaviour
{
	[SerializeField]
	GameObject arrowTemplate;

	void Update ()
	{
		if (Input.GetButtonDown("Fire"))
		{
			var go = GameObject.Instantiate(this.arrowTemplate, this.transform.position, Quaternion.identity).GetComponent<ArrowMotion>();
			go.internalMotion = new Vector3(16.0f, 4.0f, 0.0f);
		}
	}
}
