using UnityEngine;
using System.Collections;

public abstract class Creature : MonoBehaviour {

	public enum Direction{UP,DOWN,LEFT,RIGHT};


	[SerializeField]
	int maxHp;
	[SerializeField]
	protected int attackPoint;
	[SerializeField]
	protected int defencePoint;

	public Vector2 position;

	Direction direction;

	int hp;

	public int AttackPoint{
		get{return attackPoint;}
	}

	public int DefencePoint{
		get{return defencePoint;}
	}

	protected void Start(){
		hp = maxHp;
	}

	public void damage (int point){
		hp -= point;
		if (hp <= 0) {
			death ();
		}
	}
		
	protected abstract void death ();
}
