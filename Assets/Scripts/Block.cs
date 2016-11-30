using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class Block : MonoBehaviour {

	public Sprite[] sprites;

	int digPoint;
	int type;
	SpriteRenderer spriteRenderer;
	// Use this for initialization

	public Block(int type,int point){
		digPoint = point;
		this.type = type;
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = sprites [type];
	}

	public int getType(){
		return type;
	}

	public void setType(int t){
		type = t;
		spriteRenderer.sprite = sprites [type];
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
