using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	int width = 10;
	int height = 15;

	public static float unit = 1.4;//size of block

	ArrayList floors=new ArrayList();
	int maxStage=0;
	int currentStage=1;

	// Use this for initialization
	void Start () {
		makeFloor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void makeFloor(){
		floors.Add (new Floor (width,height,++maxStage));
		if (floors.Count > 50) {
			floors.RemoveAt (0);
		}
	}
}
