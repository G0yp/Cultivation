using Godot;
using System;

[GlobalClass]
public partial class CharacterStatistics : Resource
{
    // add any statistic that is relevant to the character here
    //
    // QI CULTIVATION:
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float currentQi = 0f;

    public enum CultivationRealm
    {
        QiRefining,
        FoundationEstablishment,
        CoreFormation,
        NascentSoul,
        TrueImmortal
    }

    public enum CultivationStage
    {
        Lower,
        Middle,
        Upper,
        Peak
    }

    public CultivationRealm currentRealm = CultivationRealm.QiRefining;
    public CultivationStage currentStage = CultivationStage.Lower;

    public float qiToBreakthrough = 100f;



    // BODY CULTIVATION:
    public int bodyTier = 1;


    //DAO COMPREHENSION:
    public float fireDaoComprehension;
    public float earthDaoComprehension;
    public float waterDaoComprehension;
    public float airDaoComprehension;
    public float metalDaoComprehension;


    //FOUNDATION:
    public float foundationStability;


    //ATTRIBUTES:
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
