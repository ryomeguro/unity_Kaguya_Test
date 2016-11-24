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
<<<<<<< HEAD
<<<<<<< HEAD:Assets/Cube.cs
		int i = 2;
		int j = 3000000;
=======
	
>>>>>>> origin/master:Assets/Scripts/Creature.cs
=======
		hp = maxHp;
>>>>>>> origin/master
	}
	
	// Update is called once per frame
	//ieeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeei!!!!!!!!!!!
	void Update () {
	
	}

	void damaged(){

	}

	void move(){

	}
}
