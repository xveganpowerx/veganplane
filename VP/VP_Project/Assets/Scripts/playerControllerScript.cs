using UnityEngine;
using System.Collections;

public class playerControllerScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (gameObject.transform.position.x > -6.65f) {
				gameObject.transform.Translate(-Vector2.right * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(-6.65f, gameObject.transform.position.y);
			}
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (gameObject.transform.position.x < 6.65f) {
				gameObject.transform.Translate(Vector2.right * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(6.65f, gameObject.transform.position.y);
			}
		}
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (gameObject.transform.position.y < 2) {
				gameObject.transform.Translate(Vector2.up * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(gameObject.transform.position.x, 2);
			}
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			if (gameObject.transform.position.y > -1) {
				gameObject.transform.Translate(-Vector2.up * Time.deltaTime);
			} else {
				gameObject.transform.position =  new Vector2(gameObject.transform.position.x, -1);
			}
		}
	}
}
