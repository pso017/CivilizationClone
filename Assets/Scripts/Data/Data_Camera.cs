using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Camera")]
public class Data_Camera : ScriptableObject
{
    public float minZoomDistance;
    public float maxZoomDistance;
    public float minCameraAngle;
    public float maxCameraAngle;
    public float cameraFollowSpeed;
}