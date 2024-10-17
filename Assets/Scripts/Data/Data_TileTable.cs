using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/TileTable")]
public class Data_TileTable : ScriptableObject
{
    public List<TileInfo> value = new List<TileInfo>();
}