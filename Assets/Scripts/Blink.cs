using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {

    public float delay = .5f;

	// Use this for initialization
	void Start () {
        StartCoroutine(OnBlink());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator OnBlink()
    {
        yield return new WaitForSeconds(delay);

        float alpha = transform.renderer.material.color.a;

        var newAlpha = 0f;

        if(alpha != 1) {
            newAlpha = 1f;
        }
        transform.renderer.material.color = new Color(1, 1, 1, newAlpha);

        StartCoroutine(OnBlink());
    }
}
