using Godot;
using System;
// ( ͡° ᴥ ͡°)

public partial class Hurtbox : Area2D
{
    public event Action<int> OnDamageReceived;

    public void TakeDamage(int amount)
    {
        OnDamageReceived?.Invoke(amount);
    }

}
