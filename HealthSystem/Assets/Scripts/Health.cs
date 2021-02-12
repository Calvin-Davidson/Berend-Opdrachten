using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityEvent onTakeDamage = new UnityEvent();
    public UnityEvent onRegenEvent = new UnityEvent();
    
    [SerializeField] private int maxHealth;
    [SerializeField] private int startingHealth;

    private int _health;


    public void TakeDamage(int damage)
    {
        this._health -= damage;
        if (_health < 0) _health = 0;
        
        onTakeDamage.Invoke();
    } 
    
    public void ReceiveHealth(int health)
    {
        this._health += health;
        if (_health > maxHealth) _health = maxHealth;
        
        onRegenEvent.Invoke();
    }
}
