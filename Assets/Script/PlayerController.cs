using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speedAmount; 
	private float speed;
	private float speedReset;
	public AudioClip impact;
	public CollectableManager collectableManager;

	void Start() 
		{

			speed = speedAmount;
			speedReset = speedAmount;

		}

	void Update() {

			if (Input.GetKeyDown (KeyCode.Space)) 
				{  
						speed = speed * 2f; 
				} 

			if (Input.GetKeyUp (KeyCode.Space))
		    	{
						speed = speedReset;
				}
		}

	void FixedUpdate () {

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
	
		Vector3 pos = new Vector3(x, 0f, z);

		rigidbody.AddForce(pos * speed);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Collectable") 
		{
			AudioSource.PlayClipAtPoint(impact,gameObject.transform.position);
			Destroy (other.gameObject);
			collectableManager.AddCollectable ();

		}

		if (other.transform.tag == "Water") 
		{
			Application.LoadLevel(2);
		}
	}
}
