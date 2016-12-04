using UnityEngine;
using System.Collections;

public class Floor {//: MonoBehaviour {

	int [,]blocks;
	int stage;

	// Use this for initialization
	public Floor(int width,int height,int stage){
		blocks = new int[height, width];
		this.stage = stage;
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
