using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class StartGame : MonoBehaviour {
	
	public List<int> Board;
	public bool Updated;

	public GameObject Box1;
	public GameObject Box2;
	public GameObject Box3;
	public GameObject Box4;
	public GameObject Box5;
	public GameObject Box6;
	public GameObject Box7;
	public GameObject Box8;
	public GameObject Box9;

	public Material Mat1;
	public Material Mat2;
	public Material Mat3;
	public Material Mat4;
	public Material Mat5;
	public Material Mat6;
	public Material Mat7;
	public Material Mat8;
	public Material Mat9;

	private List<GameObject> BoxList;
	private List<Material> MaterialsList;

	public GUIText CounterText;
	private float timer;


	//Fisher-Yates shuffle
	public void Shuffle()  
	{  
		System.Random rng = new System.Random();  
		int n = Board.Count; 
		int value;
		while (n > 1) {  
			n--;  
			int k = rng.Next(n + 1);  
			value = Board[k];  
			Board[k] = Board[n];  
			Board[n] = value;  
		}  
	}

	public void AssignMaterials()
	{
		for(int i = 0; i < Board.Count; i++)
		{
			BoxList[i].renderer.material = MaterialsList[Board[i]];
		}

	}

	// Use this for initialization
	void Start () {
		Board = new List<int> {0,1,2,3,4,5,6,7,8};  //change this to initialize board
		Shuffle();
		BoxList = new List<GameObject>{Box1,Box2,Box3,Box4,Box5,Box6,Box7,Box8,Box9};
		MaterialsList = new List<Material> {Mat1,Mat2,Mat3,Mat4,Mat5,Mat6,Mat7,Mat8,Mat9};
		Updated = false;		
	}
	
	// Update is called once per frame
	void Update () {



		if (Updated)
		{
			AssignMaterials();
			Updated = false;
			timer += 1;
			CounterText.text = timer.ToString("F0");
		}
				
	}

	void OnMouseDown()
	{
		AssignMaterials();	
	}




}