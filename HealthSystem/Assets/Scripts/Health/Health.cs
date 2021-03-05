using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityEvent onTakeDamage = new UnityEvent();
    public UnityEvent onRegenEvent = new UnityEvent();
    public UnityEvent onDieEvent = new UnityEvent();

    [SerializeField] private int maxHealth;
    [SerializeField] private int startingHealth;

    private int _health;


    private void Awake()
    {
        _health = startingHealth;
    }

    public void TakeDamage(int damage)
    {
        this._health -= damage;
        if (_health <= 0)
        {
            _health = 0;
            onDieEvent.Invoke();
            Debug.Log("HealthSystem Died");
        }

        onTakeDamage.Invoke();
    }

    public void ReceiveHealth(int health)
    {
        this._health += health;
        if (_health > maxHealth) _health = maxHealth;

        onRegenEvent.Invoke();
    }

    public int GetHealth()
    {
        return this._health;
    }
}