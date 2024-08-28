using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(SpriteRenderer))]
public class Piece : MonoBehaviour
{
    [SerializeField] private PieceData pieceData;

    SpriteRenderer renderer;
    public Color pathColor;

    #if UNITY_EDITOR
    private void OnValidate()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = pieceData.sprite;
    }

    private void OnDrawGizmos()
    {
        foreach(PathData path in pieceData.piecePaths)
        {
            Vector3[] localPaths = path.points.ToArray();
            this.transform.TransformPoints(localPaths);

            

            Gizmos.color = pathColor;
            Gizmos.DrawLineStrip(localPaths, false);

        }


    }
    #endif
}
