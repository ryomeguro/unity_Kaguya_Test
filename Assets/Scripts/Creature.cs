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
<<<<<<< HEAD
	Direction direction;

	int hp;
=======
	int gold;
	[SerializeField]
	int defencePoint;
	[SerializeField]
	int direction;
	[SerializeField]
	Vector2 position;
>>>>>>> origin/CreatureBranch


	void Start(){
		hp = maxHp;
	}

	public void damage (int point){
		hp -= point;
		if (hp <= 0) {
			death ();
		}
	}

<<<<<<< HEAD
	void move(Direction dir){
=======
	void damage(int point){

	}

	void move (int direction) {
>>>>>>> origin/CreatureBranch

	}

	abstract void death ();
}
