using UnityEngine;
using System.Collections;

public abstract class Creature : MonoBehaviour {

	public enum Direction{UP,DOWN,LEFT,RIGHT};

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


	protected void Start(){
		hp = maxHp;
	}

	public void damage (int point){
		hp -= point;
		if (hp <= 0) {
			death ();
		}
	}
		

	protected void move (Direction direction) {

	}

	protected abstract void death ();
}
