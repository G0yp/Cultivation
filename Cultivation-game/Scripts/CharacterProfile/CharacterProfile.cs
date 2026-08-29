using Godot;
using System;
// ( ͡° ᴥ ͡°)

[GlobalClass]
public partial class CharacterProfile : Resource
{
    // List of pinned stats to show in pinned stat page
    public class PinnedStats
    {
        Attributes Stat1 { get; set; }
        Attributes Stat2 { get; set; }
        Attributes Stat3 { get; set; }
        Attributes Stat4 { get; set; }
        Attributes Stat5 { get; set; }
        Attributes Stat6 { get; set; }
    }

    // Pinned stats/Overview:
    //
    // Player stats:
    // Cultivation (realms, Qi, Body)
    // Attributes (strength, agility, wisdom, etc...)
    // Skills
    // Dao (locked until core formation)
    // Reputation
    //
    // All below not character profile
    // Inventory:
    // Questbook:
    // Journal:
    // Settings:
    //

    [ExportCategory("Progression")]
    [Export] public CultivationStats Cultivation { get; set; }
    public float talent = 1f;

    // All current Attributes level off of being used/exercised
    [ExportCategory("Player stats")]
    [ExportSubgroup("Attributes")]
    [Export] public Attributes Strength { get; set; }
    [Export] public Attributes Defense { get; set; }
    [Export] public Attributes Agility { get; set; }
    [Export] public int StatCap { get; set; }
    [ExportSubgroup("Skills")]
    [Export] public Attributes Blacksmithing { get; set; }
    [Export] public Attributes Farming { get; set; }
    [Export] public Attributes Enchanting { get; set; }
    [Export] public Attributes Exploring { get; set; }
    [Export] public Attributes MartialArts { get; set; }
    [ExportSubgroup("Dao")]
    [Export] public Attributes Fire { get; set; }
    [Export] public Attributes Earth { get; set; }
    [Export] public Attributes Water { get; set; }
    [Export] public Attributes Metal { get; set; }
    [Export] public Attributes Air { get; set; }
    [Export] public Attributes Qi { get; set; }
    [Export] public Attributes Karma { get; set; }




}
