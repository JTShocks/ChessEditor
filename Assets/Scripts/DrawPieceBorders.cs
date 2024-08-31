using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PieceBorders))]
public class DrawPieceBorders : Editor
{
    void OnSceneGUI()
    {
        Handles.color = Color.blue;
        PieceBorders bordersAroundPieces = (PieceBorders)target;

        Vector3 areaOfBorders = new Vector3(bordersAroundPieces.borderArea, bordersAroundPieces.borderArea, bordersAroundPieces.borderArea);

        Handles.DrawWireCube(bordersAroundPieces.transform.position, areaOfBorders);
    }

}
