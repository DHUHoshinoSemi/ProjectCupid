using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoFire : MonoBehaviour
{
	[SerializeField]
	GameObject arrowTemplate;
	private float bowStrength = 0.0f;
	[SerializeField]
	UnityEngine.UI.Image reactionTarget;

	void Update ()
	{
		this.bowStrength = Mathf.Clamp01(this.bowStrength + Input.GetAxis("Horizontal") * Time.deltaTime);
		this.reactionTarget.rectTransform.sizeDelta = new Vector2(this.reactionTarget.rectTransform.sizeDelta.x, this.bowStrength * 128.0f);
		if (Input.GetButtonDown("Fire"))
		{
			var go = GameObject.Instantiate(this.arrowTemplate, this.transform.position, Quaternion.identity).GetComponent<ArrowMotion>();
			go.internalMotion = new Vector3(2.0f, 0.0f, 0.0f) + new Vector3(14.0f, 4.0f, 0.0f) * this.bowStrength;
		}
	}
}
