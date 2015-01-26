using UnityEngine;
using System.Collections;

public class ControlsUI : MonoBehaviour {

    public Texture leftArrow;
    public Texture rightArrow;
    public Vector2 offset = new Vector2(10, 20);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (leftArrow)
            GUI.DrawTexture(new Rect(offset.x, offset.y, leftArrow.width, leftArrow.height), leftArrow);

        if (rightArrow)
            GUI.DrawTexture(new Rect(Screen.width - rightArrow.width - offset.x, offset.y, rightArrow.width, rightArrow.height), rightArrow);
    }
}
