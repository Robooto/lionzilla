using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

    public int maxHealth = 10;
    public int health = 10;
    public AudioClip deathSound;
    public AudioClip hurtSound;
    public Image healthBar;


    public GameObject deathInstance = null;
    public Vector2 deathInstanceOffset = new Vector2(0, 0);

	// Use this for initialization
	void Start () {
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void TakeDamage(int value)
    {
        float healthBarDmg = ((float)value / (float)maxHealth);

        if(healthBar)
            healthBar.fillAmount -= healthBarDmg;

        health -= value;
        if (hurtSound)
            AudioSource.PlayClipAtPoint(hurtSound, transform.position);

        if (health <= 0)
        {
            OnKill();
        }
    }

    void OnKill()
    {
        if (deathInstance)
        {
            var pos = gameObject.transform.position;
            GameObject clone = Instantiate(deathInstance, new Vector3(pos.x + deathInstanceOffset.x, pos.y + deathInstanceOffset.y, pos.z), Quaternion.identity) as GameObject;

            if (deathSound)
                AudioSource.PlayClipAtPoint(deathSound, transform.position);
        }
        Destroy(gameObject);
    }
}
