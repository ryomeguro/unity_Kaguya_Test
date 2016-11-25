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

	void move(Direction dir){

	}

	abstract void death ();
}
