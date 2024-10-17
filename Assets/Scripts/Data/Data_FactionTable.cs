using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/FactionTable")]
public class Data_FactionTable : ScriptableObject
{
    public List<FactionInfo> value = new List<FactionInfo>();
}

[System.Serializable]
public class FactionInfo
{
    public FactionEnum key;
    public string factionName;
    public string factionDescription;
    public string leaderName;
    public string leaderDescription;
    public PerkEnum[] perks;
    public SkillEnum[] skills;
}