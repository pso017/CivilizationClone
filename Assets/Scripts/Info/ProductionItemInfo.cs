using System.Collections;
using UnityEngine;

[System.Serializable]
public class ProductionItemInfo
{
    public ProductionItemEnum key;
    public string name;
    public ProductionItemTypeEnum itemType;
    public UnitTypeEnum unitType;
    public string description;
    public int requiredProductivity;
    public PropertyInfo status;
}