using Godot;
using System;

public partial class CharacterStatistics : Resource
{
    // add any statistic that is relevant to the character here
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float qiRealm = 1;
    public float bodyTier = 1;
    public float fireDaoComprehension;
    public float earthDaoComprehension;
    public float waterDaoComprehension;
    public float airDaoComprehension;
    public float metalDaoComprehension;
    public float foundationStability;
    public int strength;
    public int strExp;
    public int defense;
    public int defExp;
    public int agility;
    public int agiExp;
    public int charisma;
    public int chaExp;
    public int wisdom;
    public int wisExp;
    public float talent = 1;

    // this file will get very big so we may want to make sections
    // also maybe handle some of the processing here like updating the qi rates

}
