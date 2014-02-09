using UnityEngine;
using System.Collections;


public class RotationB : MonoBehaviour {
	
	StartGame startscript;
	private int aux1,aux2,aux3,aux4;
	
	// Use this for initialization
	void Start () {
		
		GameObject StartButton = GameObject.Find("ButtonStart");
		startscript = StartButton.GetComponent<StartGame>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown()
	{
		aux1 = startscript.Board[1];
		aux2 = startscript.Board[2];
		aux3 = startscript.Board[4];
		aux4 = startscript.Board[5];
		
		
		startscript.Board[1] = aux3;
		startscript.Board[2] = aux1;
		startscript.Board[4] = aux4;
		startscript.Board[5] = aux2;
		
		startscript.Updated = true;
		
	}
}