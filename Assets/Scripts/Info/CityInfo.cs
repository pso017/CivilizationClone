using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CityInfo
{
    public string cityName;
    public FactionEnum faction;
    public int hp;
    public int maxhp;
    public int loyalty;
    public int devoutCitizen;
    public int comfortLevel;
    public int citizenNum;
    public int livingSpaceNum;
    public int cultureByTurn;
    public int foodByTurn;
    public int productivityByTurn;
    public int scienceByTurn;
    public int FaithByTurn;
    public int goldByTurn;
    public Vector2Int tilePos;
    public CitizenGrowthInfo citizenGrowthInfo;
    public ComfortLevelInfo comfortLevelInfo;
    public LivingSpaceInfo livingSpaceInfo;
    public List<ProductionQueueInfo> productionQueue;
}