using Godot;
using System;

[GlobalClass]
public partial class Attributes : Resources
{
    public int level = 1;
    public float currentXp = 0f;

    public float GetRequiredXpForNextLevel()
    {
        return 100f * Math.Pow(Level, 1.3f);
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
