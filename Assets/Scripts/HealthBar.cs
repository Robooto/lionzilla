using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {

    public Texture backgroundTexture;
    public Texture foregroundTexture;
    public Texture borderTexture;
    public Vector2 offset = new Vector2();
    public GameObject target;
    private int barWidth;
    private int barHeight;
    private Health targetHealthComponent;
    public Image healthBar;

	// Use this for initialization
	void Start () {
        barWidth = borderTexture.width;
        barHeight = borderTexture.height;
        targetHealthComponent = target.GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.fillAmount = ((float)targetHealthComponent.health / (float)targetHealthComponent.maxHealth);
	}

    void OnGUI()
    {
        var percent = ((double)targetHealthComponent.health / (double)targetHealthComponent.maxHealth);
        GUI.DrawTexture(new Rect(offset.x, offset.y, barWidth, barHeight), backgroundTexture);
        GUI.DrawTexture(new Rect(offset.x, offset.y, (int)System.Math.Round(barWidth * percent), barHeight), foregroundTexture);
        GUI.DrawTexture(new Rect(offset.x, offset.y, barWidth, barHeight), borderTexture);
    }
}
