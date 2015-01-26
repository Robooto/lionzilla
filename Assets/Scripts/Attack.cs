using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    public int attackValue = 1;
    public float attackDelay = 1f;
    public string targetTag;
    public AudioClip attackSound;
    private bool canAttack;

	// Use this for initialization
	void Start () {
        if (attackValue <= 0)
            canAttack = false;
        else
            StartCoroutine(OnAttack());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay2D(Collision2D c)
    {
        if (c.gameObject.tag == targetTag)
        {
            if (canAttack)
                TestAttack(c.gameObject);
        }
    }

    void TestAttack(GameObject target)
    {
        if (transform.localScale.x == 1)
        {
            if (target.transform.position.x > transform.position.x)
                AttackTarget(target);
        }
        else
        {
            if (target.transform.position.x < transform.position.x)
                AttackTarget(target);
        }
        canAttack = false;
    }

    void AttackTarget(GameObject target)
    {
        var healthComponent = target.GetComponent<Health>();
        if (healthComponent)
            healthComponent.TakeDamage(attackValue);

        if (attackSound)
            AudioSource.PlayClipAtPoint(attackSound, transform.position);
    }

    IEnumerator OnAttack()
    {
        yield return new WaitForSeconds(attackDelay);
        canAttack = true;
        StartCoroutine(OnAttack());
    }
}
