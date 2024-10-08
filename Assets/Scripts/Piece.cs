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
    public float sphereRadius;

    #if UNITY_EDITOR
    private void OnValidate()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = pieceData.sprite;
    }

    private void OnDrawGizmosSelected()
    {
        foreach(PathData path in pieceData.piecePaths)
        {
            Vector3[] localPaths = path.points.ToArray();
            this.transform.TransformPoints(localPaths);

            

            Gizmos.color = pathColor;
            Gizmos.DrawLineStrip(localPaths, false);

            Gizmos.DrawSphere(localPaths[localPaths.Length - 1], sphereRadius);

            /* for (int i = 0; i < localPaths.Length; i++) 
             {
                 Gizmos.DrawSphere(localPaths[i], sphereRadius);
             }*/
        }


    }
    #endif
}
