using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoman : MonoBehaviour
{
    [SerializeField] AudioClip damageSfx;

    public Animator myAnimator;

    public int maxHealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        myAnimator.SetTrigger("Hurt");
        AudioSource.PlayClipAtPoint(damageSfx, Camera.main.transform.position);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        myAnimator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}