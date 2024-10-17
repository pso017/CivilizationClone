using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/PlayerList")]
public class Data_PlayerList : ScriptableObject
{
    public List<PlayerInfo> value = new List<PlayerInfo>();
}