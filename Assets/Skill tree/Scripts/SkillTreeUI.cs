using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillTreeUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI skillPoints;

    void Start() 
    {
        UpdateSkillTreeUI();
    }

    public void UpdateSkillTreeUI()
    {
        UpdateSkillPointsText();
        UpdateSkillButtonColors();
    }

    void UpdateSkillPointsText()
    {
        skillPoints.text = "Skill Points: " + SkillTree.SkillTreeInstance.skillPoints;
    }

    void UpdateSkillButtonColors()
    {
        foreach(Skill skill in GetComponentsInChildren<Skill>())
        {
            if(skill.skillData.isUnlocked)
            {
                skill.gameObject.GetComponent<Image>().color = Color.green; 
            }
            else
            {
                skill.gameObject.GetComponent<Image>().color = Color.red; 
            }
        }
    }
}
