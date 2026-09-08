using Godot;
using System;
// ( ͡° ᴥ ͡°)

namespace CultivationGame.Combat;

public partial class Hitbox : Area2D
{
    [Export] public int Damage { get; set; } = 10;

    public override void _Ready()
    {
        AreaEntered += OnAreaEntered;
    }

    private void OnAreaEntered(Area2D area)
    {
        if (area is Hurtbox hurtbox)
        {
            hurtbox.TakeDamage(Damage);
        }
    }

}
