using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MachineChess
{
    public class pseudo3D : MonoBehaviour
    {
        SpriteRenderer sr;
        float y;

        // Use this for initialization
        void Start()
        {
            sr = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            y = transform.position.y;
            sr.sortingOrder = (int)(y * -10)+1;
        }
    }
}
