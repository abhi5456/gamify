using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MachineChess
{
    public class bullet : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            GetComponent<Rigidbody2D>().position += new Vector2(8, 0) * Time.fixedDeltaTime;
        }


    }
}
