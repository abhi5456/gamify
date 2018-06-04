using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MachineChess
{
    public class LaserBlast : PlayerAbility
    {
        public GameObject laserbolt;

        void Start()
        {
            cooldown = 2;
        }

        public override void Execute(GameObject invoker)
        {
            base.Execute(invoker);
            Instantiate (laserbolt, invoker.transform.position, Quaternion.identity);
            GameManager.instance.playersTurn = false;
            cooldown = 2;

            return;
        }

    }
}
