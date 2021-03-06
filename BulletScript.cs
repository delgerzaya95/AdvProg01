using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	//now in playershootbullet Shoot()
	//Transform gunPoint;
	float speed = 1f;
	EnemyMovement enemy; 		 
//	void Start()
//	{
//		//now initialized in playershootbullet Shoot()
//	//	gunPoint = GetComponentInParent<Transform> ();
//	//	transform.position = gunPoint.position;
//		//	transform.rotation = gunPoint.rotation;
//	}
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			transform.Translate (transform.forward * -speed);
		}
		//if collide with enemy, damage and setactive(false)
		//if()
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Enemy")) {
			enemy = collision.gameObject.GetComponent<EnemyMovement>();
		//	enemy.TakeDamage (20, new Vector3 (0, 0, 0));
			enemy.TakeDamage (20, collision.collider.transform.position);

			Debug.Log ("Target Hit");
			gameObject.SetActive (false);
		}
		else if(collision.gameObject.CompareTag("Wall")){
			Debug.Log ("Wall Hit");
			gameObject.SetActive (false);
		}
		Debug.Log (collision.transform.tag);
	//	for (int i = 0; i < bullets.Count; i++) {
	//		bullets [i].GetComponent<SphereCollider> ();
	//	}
	}

	//void OnCollisionExit(Collision collision)
	//{
	//	collision.rigidbody.isKinematic = false;
	//}

	void OnEnable()
	{
		Invoke ("Destroy", 2.0f);
	}

	void Destroy()
	{
		gameObject.SetActive (false);
	}

	void OnDisable()
	{
		CancelInvoke ();
	}
}
