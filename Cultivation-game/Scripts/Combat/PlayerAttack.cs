using Godot;
using System;
// ( ͡° ᴥ ͡°)

namespace CultivationGame.Combat;

public partial class PlayerAttack : Node
{
    [Export] public Area2D hitbox;
    [Export] public CollisionShape2D hitboxShape;
    public override void _Ready()
    {
        hitboxShape.Disabled = true;
    }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("Attack"))
        {
            Attack();
        }
    }

    private async void Attack()
    {
        hitboxShape.Disabled = false;

        await ToSignal(GetTree().CreateTimer(0.15f), SceneTreeTimer.SignalName.Timeout);

        hitboxShape.Disabled = false;
    }
}
