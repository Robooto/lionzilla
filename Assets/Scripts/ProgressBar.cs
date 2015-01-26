using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBar : MonoBehaviour {
    public GameObject target;
    private Health targetHealthComponent;
    public Image healthBar;

	// Use this for initialization
	void Start () {
        targetHealthComponent = target.GetComponent<Health>();
        Debug.Log(targetHealthComponent.health);
	}
	
	// Update is called once per frame
	void Update () {

    //    Debug.Log(targetHealthComponent.health);
        Image image = GetComponent<Image>();

        //image.fillAmount = percent;
	}
}
