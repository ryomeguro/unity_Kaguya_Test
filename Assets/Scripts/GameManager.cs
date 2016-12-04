using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static float unit = 0.4f;//size of block

	public Hero hero;

	int width = 10;
	int height = 15;

	ArrayList floors=new ArrayList();
	int maxStage=0;
	int currentStage=1;

	bool turnFree=true;

	// Use this for initialization
	void Start () {
		makeFloor ();
	}
	
	// Update is called once per frame
	void Update () {
		Creature.Direction dir = Creature.Direction.UP;
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			dir = Creature.Direction.UP;
			turnFree = false;
		}else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			dir = Creature.Direction.DOWN;
			turnFree = false;
		}else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			dir = Creature.Direction.LEFT;
			turnFree = false;
		}else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			dir = Creature.Direction.RIGHT;
			turnFree = false;
		}

		if (!turnFree && hero.move(dir)) {
			turnFree = true;
		}
	}

	void makeFloor(){
		floors.Add (new Floor (width,height,++maxStage));
		if (floors.Count > 50) {
			floors.RemoveAt (0);
		}
	}
}
