using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MachineChess
{
    public class PlayerAbility : MonoBehaviour
    {
        public int cooldown;

        public virtual void Execute(GameObject invoker)
        {
            GameObject.Find("QuizExtension").GetComponent<QuizExtension>().Display();
        }

    }
}
