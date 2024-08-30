using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Board : MonoBehaviour
{

    public Color space1;
    public Color space2;

    bool isWhiteSpace = false;

    #if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        for(int x = 0; x < 8; x++)
        {
            for(int y = 0; y < 8; y++)
            {
                if(isWhiteSpace)
                {
                    Gizmos.color = space1;

                }
                else
                {
                    Gizmos.color = space2;
                }
                Gizmos.DrawWireCube(new Vector3(x, y, 0), Vector3.one);
                isWhiteSpace = !isWhiteSpace;
            }
            isWhiteSpace = !isWhiteSpace;
        }
    }

    #endif
}
