using UnityEngine;
using System.Collections;

public class Creature : MonoBehaviour {

	enum Direction{UP,DOWN,LEFT,RIGHT};

	[SerializeField]
	int maxHp;
	[SerializeField]
	int gold;

	int hp;

	// Use this for initialization
	void Start () {
		hp = maxHp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void damaged(){

	}

	void move(){

	}
}
