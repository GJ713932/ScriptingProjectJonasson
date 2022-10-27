using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingIfstatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        coffeeTemperature -= Time.deltaTime * 5f;
    }



    void TemperatureTest()
    {
        //IF the coffee's tempeature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot");
            }
        // Iff itn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this
            print("Coffee is too cold");
        }
        // If it is neither of those then...
        else
        {
            // .. do this.
            print("Coffee is just right");
        }
    }
}
