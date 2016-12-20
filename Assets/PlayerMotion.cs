using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
	[SerializeField]
	float speed = 3.0f;
		
	// Update is called once per frame
	void Update ()
	{
		var tf = this.transform.position;
		tf += Vector3.up * Input.GetAxis("Vertical") * this.speed * Time.deltaTime;
		tf.y = Mathf.Clamp(tf.y, -5.0f + this.transform.localScale.y * 5.0f, 5.0f - this.transform.localScale.y * 5.0f);
		this.transform.position = tf;
	}
}
