using UnityEngine;
using System.Collections;

public class playerControllerScript : MonoBehaviour {
	private float leftBorder;
	private float rightBorder;
	public int playerSpeed = 5;
	// Use this for initialization

	void Awake() {
		leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,-10)).x;
		rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1,0,-10)).x;
	}
	void Start () {
		print ("" + leftBorder + ";" + rightBorder);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (gameObject.transform.position.x > leftBorder) {
				gameObject.transform.Translate(-Vector2.right * 5 * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(leftBorder, gameObject.transform.position.y);
			}
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (gameObject.transform.position.x < rightBorder) {
				gameObject.transform.Translate(Vector2.right * 5 * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(rightBorder, gameObject.transform.position.y);
			}
		}
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (gameObject.transform.position.y < 2) {
				gameObject.transform.Translate(Vector2.up * 5 * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(gameObject.transform.position.x, 2);
			}
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			if (gameObject.transform.position.y > -1) {
				gameObject.transform.Translate(-Vector2.up * 5 * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(gameObject.transform.position.x, -1);
			}
		}
	}
}
