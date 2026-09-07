using Godot;
using System;
using CultivationStats;
// ( ͡° ᴥ ͡°)

[GlobalClass]
public partial class CharacterProfile : Resource
{
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


    // Creates a globally accessible instance of CharacterProfile
    public static CharacterProfile Instance { get; private set; }

    public override void _Ready()
    {
        Instance = this;
    }


    //Cultivation
    public CultivationStats Cultivation { get; set; }

    // All current Attributes level off of being used/exercised
    public Attributes Strength { get; set; }
    public Attributes Defense { get; set; }
    public Attributes Agility { get; set; }
    public int StatCap { get; set; }

    // skills
    public Attributes Blacksmithing { get; set; }
    public Attributes Farming { get; set; }
    public Attributes Enchanting { get; set; }
    public Attributes Exploring { get; set; }
    public Attributes MartialArts { get; set; }

    // Daos
    public Attributes Fire { get; set; }
    public Attributes Earth { get; set; }
    public Attributes Water { get; set; }
    public Attributes Metal { get; set; }
    public Attributes Air { get; set; }
    public Attributes Qi { get; set; }
    public Attributes Karma { get; set; }




}
