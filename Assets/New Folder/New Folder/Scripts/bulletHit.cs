using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour {

	public float weaponDamgage;

	projectileController myPC;

	public GameObject bulletExplosion;

	void Awake(){
		myPC = GetComponentInParent<projectileController> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Shootable") {
			myPC.removeForce ();
			Instantiate (bulletExplosion, transform.position, transform.rotation);
			Destroy (gameObject);
			if (other.gameObject.layer == LayerMask.NameToLayer ("enemy")) {
				enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth> ();
				hurtEnemy.addDamge (weaponDamgage);
			}
		}
	}

	void OnTringgerStay2D(Collider2D other){
		if (other.gameObject.tag == "Shootable") {
			myPC.removeForce ();
			Instantiate (bulletExplosion, transform.position, transform.rotation);
			Destroy (gameObject);
			if (other.gameObject.layer == LayerMask.NameToLayer ("enemy")) {
				enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth> ();
				hurtEnemy.addDamge (weaponDamgage);
			}
		}
	}
}
