using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[Serializable]
public class PieceData : ScriptableObject
{

    public string Name;
    public Sprite sprite;

    public List<PathData> piecePaths;

}
[Serializable]
public class PathData
{
    public List<Vector3> points;


}

