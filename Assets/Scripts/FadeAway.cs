using UnityEngine;
using System.Collections;

public class FadeAway : MonoBehaviour {

    public float delay = 2.0f;
	// Use this for initialization
	void Start () {
        StartCoroutine(FadeTo(0.0f, 1.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator FadeTo(float aValue, float aTime)
    {
        yield return new WaitForSeconds(delay);

        float alpha = transform.renderer.material.color.a;
        for (float t = 0.0f; t <= 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            transform.renderer.material.color = newColor;

            if (newColor.a <= 0.05)
                Destroy(gameObject);
            yield return null;
        }
    }
}
