using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] public SkillData skillData;

    public void UnlockSkill()
    {
        //Check if player has enough skill points
        if(!HasSufficientSkillPoints())
        {
            Debug.Log("Not Enough Skill Points");
            return;
        }

        //Skip unlocking if skill is already unlocked
        if(skillData.isUnlocked) 
        { 
            Debug.Log("Skill already unlocked");
            return; 
        }

        //Check if previous skills are unlocked
        if(SkillTree.SkillTreeInstance.CanUnlockSkill(skillData.requiredSkills))
        {
            SkillTree.SkillTreeInstance.skillPoints -= skillData.skillCost;
            skillData.isUnlocked = true;
            SkillTree.SkillTreeInstance.skillTreeUI.UpdateSkillTreeUI();
            ActivateSkill();
        }
    }

    bool HasSufficientSkillPoints()
    {
        if(skillData.skillCost > SkillTree.SkillTreeInstance.skillPoints)
        {
            return false;
        }
        return true;
    }
    
    public void ActivateSkill()
    {
        switch(skillData.skillEffect)
        {
            case SkillData.SkillEffect.skill_1:
                Skill1();
                return;
            case SkillData.SkillEffect.skill_2:
                Skill2();
                return;
            case SkillData.SkillEffect.skill_3:
                Skill3();
                return;
            case SkillData.SkillEffect.skill_4:
                Skill4();
                return;
            case SkillData.SkillEffect.skill_5:
                Skill5();
                return;
            case SkillData.SkillEffect.skill_6:
                Skill6();
                return;
            case SkillData.SkillEffect.skill_7:
                Skill7();
                return;
            case SkillData.SkillEffect.skill_8:
                Skill8();
                return;
            case SkillData.SkillEffect.skill_9:
                Skill9();
                return;
        }
    }

    private void Skill9()
    {
        Debug.Log("Skill 9 activated");
    }

    private void Skill8()
    {
        Debug.Log("Skill 8 activated");
    }

    private void Skill7()
    {
        Debug.Log("Skill 7 activated");
    }

    private void Skill6()
    {
        Debug.Log("Skill 6 activated");
    }

    private void Skill5()
    {
        Debug.Log("Skill 5 activated");
    }

    private void Skill4()
    {
        Debug.Log("Skill 4 activated");
    }

    private void Skill3()
    {
        Debug.Log("Skill 3 activated");
    }

    private void Skill2()
    {
        Debug.Log("Skill 2 activated");
    }

    private void Skill1()
    {
        Debug.Log("Skill 1 activated");
    }
}
