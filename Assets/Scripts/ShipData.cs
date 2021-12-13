using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName = "Data", menuName = "Ship", order = 1)]
public class ShipData : ScriptableObject
{
    public string spaceshipName;
    [Range(1f, 10f)]
    public float speed;
    [Range(1f, 10f)]
    public float shield;
    [Range(1f, 10f)]
    public float rof;

}
