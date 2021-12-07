using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGooba : MonoBehaviour
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

        AudioSource.PlayClipAtPoint(damageSfx, Camera.main.transform.position);

        if (currentHealth < 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}