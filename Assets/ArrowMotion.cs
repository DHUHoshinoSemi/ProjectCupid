using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMotion : MonoBehaviour
{
	public Vector3 internalMotion = new Vector3(16.0f, 0.0f, 0.0f);
	[SerializeField]
	float gravityMagnitude = 9.82f;
		
	// Update is called once per frame
	void Update ()
	{
		this.internalMotion += Vector3.down * this.gravityMagnitude * Time.deltaTime;
		this.transform.localRotation = Quaternion.AngleAxis(Mathf.Atan2(this.internalMotion.y, this.internalMotion.x) * Mathf.Rad2Deg, Vector3.forward)
			* Quaternion.AngleAxis(90.0f, Vector3.left);
		this.transform.position = this.transform.position + this.internalMotion * Time.deltaTime;
	}
}
