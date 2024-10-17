using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/PerkTable")]
public class Data_PerkTable : ScriptableObject
{
    public List<PerkInfo> value = new List<PerkInfo>();
}