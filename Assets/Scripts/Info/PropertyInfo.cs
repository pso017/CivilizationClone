using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PropertyInfo
{
    public List<PropertyPairInt> intList = new List<PropertyPairInt>();
    public List<PropertyPairString> stringList = new List<PropertyPairString>();
    public List<PropertyPairFloat> floatList = new List<PropertyPairFloat>();
}