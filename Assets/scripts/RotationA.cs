using UnityEngine;
using System.Collections;

public class RotationA : MonoBehaviour {
	
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
		aux1 = startscript.Board[0];
		aux2 = startscript.Board[1];
		aux3 = startscript.Board[3];
		aux4 = startscript.Board[4];
		
		
		startscript.Board[0] = aux3;
		startscript.Board[1] = aux1;
		startscript.Board[3] = aux4;
		startscript.Board[4] = aux2;
		
		startscript.Updated = true;
		
	}
}