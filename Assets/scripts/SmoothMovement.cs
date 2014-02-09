using UnityEngine;
using System.Collections;

public class SmoothMovement : MonoBehaviour {

	public GameObject box;
	int Speed;
	Vector2 direction;
	float Xposition;


	// Use this for initialization
	void Start () {
		Speed = 0;
		direction= new Vector2(1f,1f);
		Xposition = box.transform.position.x;
			
	}
	
	// Update is called once per frame
	void Update () {
		box.transform.Translate(direction * Time.deltaTime * Speed,Space.World);
		Xposition = box.transform.position.x;

		if (Xposition >= 5)
		{
			Speed = 0;
		}

	}

	void OnMouseDown()
	{
		Speed=2;
	}


}
