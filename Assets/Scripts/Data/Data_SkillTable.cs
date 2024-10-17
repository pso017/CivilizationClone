using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/SkillTable")]
public class Data_SkillTable : ScriptableObject
{
    public List<SkillInfo> value = new List<SkillInfo>();
}