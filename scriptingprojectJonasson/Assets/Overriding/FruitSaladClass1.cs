using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple myApple = new Apple();

        myApple.SayHello();
        myApple.Chop();

        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
