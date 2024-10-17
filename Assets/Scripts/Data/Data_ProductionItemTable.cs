using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/ProductionItemTable")]
public class Data_ProductionItemTable : ScriptableObject
{
    public List<ProductionItemInfo> value = new List<ProductionItemInfo>();
}