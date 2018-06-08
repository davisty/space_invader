using UnityEngine;
using System.Collections;

public class randomBehavior : MonoBehaviour {
	public GameObject projectile;
	public float projectileSpeed = 3f;
	public float shotsPerSecond = .9f;
	
	public AudioClip fireSound;
	public AudioClip deathSound;
	
	private ScoreKeeper scoreKeeper;


	void Update(){
		float prob = shotsPerSecond * Time.deltaTime;
		if(Random.value < prob){
			Fire ();
		}
	}
	
	void Fire(){
		GameObject laser = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
		laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0,+projectileSpeed);
		AudioSource.PlayClipAtPoint(fireSound, transform.position);
	}
	
}
