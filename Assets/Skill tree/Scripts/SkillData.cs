using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill")]
public class SkillData : ScriptableObject
{
    public enum SkillEffect
    {
        skill_1, skill_2, skill_3, skill_4, skill_5, skill_6, skill_7, skill_8, skill_9, skill_10
    }

    public int id;
    public int skillCost;
    public SkillEffect skillEffect;
    public bool isUnlocked;
    public List<int> requiredSkills;
}
