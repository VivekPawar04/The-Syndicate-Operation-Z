using System.Collections.Generic;
using UnityEngine;


public class SkillTree : MonoBehaviour
{
    public static SkillTree SkillTreeInstance;
   
    public int skillPoints = 1;

    public SkillTreeUI skillTreeUI;

    void Awake()
    {
        if(SkillTreeInstance != null)
        {
            return;
        }

        SkillTreeInstance = this;
        // DontDestroyOnLoad(SkillTreeInstance);
    }

    void Start()
    {
        skillTreeUI = GetComponent<SkillTreeUI>();
    }

    public bool CanUnlockSkill(List<int> requiredSkills)
    {
        //return true if no previous skills are required (Mainly for the first skill) 
        if(requiredSkills.Count == 0)
        {
            return true;
        }

        //Check if previous required skills are unlocked
        foreach(Skill skill in GetComponentsInChildren<Skill>())
        {
            foreach(int id in requiredSkills)
            {
                if(id == skill.skillData.id && skill.skillData.isUnlocked)
                {
                    return true;
                }
            }
        }
        
        //Log if previous skills need to be unlocked
        foreach(int i in requiredSkills)
        {
            Debug.Log("Skill " + i + " is required to be unlocked before you can unlock this skill");
        }
        return false;
    }

    
}
