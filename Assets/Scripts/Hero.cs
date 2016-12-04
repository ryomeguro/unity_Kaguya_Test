using UnityEngine;
using System.Collections;

public class Hero : Creature {
	private int level;
	private int ex;
	private int gold;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public bool move(Direction direction){
		Vector2 dir = Vector2.zero;

		switch (direction) {
		case(Direction.UP):
			//Debug.Log ("aaa");
			dir = new Vector2 (0, 1);
			break;
		case(Direction.DOWN):
			dir = new Vector2(0,-1);
			break;
		case(Direction.LEFT):
			dir = new Vector2(-1,0);
			break;
		case(Direction.RIGHT):
			dir = new Vector2(1,0);
			break;
		default:
			break;
		}
		if (true) {//whether can dig?
			dig (position + dir);
		} else if (false) {//whether can attack?

			return true;
		} else if (false) {//whether can't move?
			return false;
		}
		transform.position = transform.position + (Vector3)dir * GameManager.unit;
		return true;
	}

	void dig (Vector2 blockPosition) {

	}

	void useItem (int item) {

	}

	protected override void death ()
	{
		//throw new System.NotImplementedException ();
	}
}
