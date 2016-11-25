using UnityEngine;
using System.Collections;

public abstract class Creature : MonoBehaviour {

	enum Direction{UP,DOWN,LEFT,RIGHT};

	[SerializeField]
	int maxHp;
	[SerializeField]
	int attackPoint;
	[SerializeField]
	int defencePoint;
	[SerializeField]
	Vector2 position;
	[SerializeField]

	Direction direction;

	int hp;



	void Start(){
		hp = maxHp;
	}

	public void damage (int point){
		hp -= point;
		if (hp <= 0) {
			death ();
		}
	}
		
	void damage(int point){

	}

	void move (int direction) {

	}

	abstract void death ();
}
