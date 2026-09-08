using Godot;
using System;
using CultivationGame.Cultivation;
// ( ͡° ᴥ ͡°)

namespace CultivationGame.Profile;

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



    //Cultivation
    public CultivationStats Cultivation { get; set; } = new CultivationStats();

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
