﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.layer == 9) {
			if (other.tag == "SqrPowerup") {
				Destroy (other.gameObject);
				transform.parent.GetComponent<LoadPlayer> ().changePlayer (1);
			} else if (other.tag == "TriPowerup") {
				Destroy (other.gameObject);
				transform.parent.GetComponent<LoadPlayer> ().changePlayer (2);
			} else if (other.tag == "LifePowerup") {
				Destroy (other.gameObject);
				GetComponent<Health> ().addHealth (5);
			} else if (other.tag == "BulletPowerup") {
				Destroy (other.gameObject);
				GetComponent<Shoot>().SuperFirePoint ();
			}
		}
    }
}
