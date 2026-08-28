using Godot;
using System;

public partial class CharacterProfile : Resource
{
    [ExportCategory("Progression")]
    [Export] public CultivationStats Cultivation { get; set; }
    public float talent = 1f;

    [ExportCategory("Body Cultivation (Attributes)")]
    [Export] public Attributes Strength { get; set; }
    [Export] public Attributes Defense { get; set; }
    [Export] public Attributes Agility { get; set; }

}
