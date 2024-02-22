using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandClass : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemyClass();
        Humanoid orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}