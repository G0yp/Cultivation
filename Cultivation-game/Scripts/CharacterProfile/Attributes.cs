using Godot;
using System;
// ( ͡° ᴥ ͡°)

[GlobalClass]
public partial class Attributes : Resource
{
    public int level = 1;
    public float currentXp = 0f;

    public float GetRequiredXpForNextLevel()
    {
        return (float)(100.0 * Math.Pow((double)level, 1.3));
    }

    public void AddXp(float amount, int levelCap)
    {
        if (level >= levelCap) return;

        currentXp += amount;

        while (currentXp >= GetRequiredXpForNextLevel() && level < levelCap)
        {
            currentXp -= GetRequiredXpForNextLevel();
            level++;
            if (level == levelCap)
            {
                currentXp = 0;
                break;
            }
        }
    }

}
