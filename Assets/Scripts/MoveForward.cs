using UnityEngine;
using System.Collections;

/*
 * Move our enemies forward
 */
public class MoveForward : MonoBehaviour {

    public float speed = .3f;
	
	// Update is called once per frame
	void Update () {
        rigidbody2D.velocity = new Vector2(this.transform.localScale.x, 0) * speed;
	}
}
