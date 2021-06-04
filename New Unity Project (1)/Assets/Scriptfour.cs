using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptfour : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.DeltaTime * 5f;  
    }

    void TemperatureTest ()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(CoffeeTemperature > hotLimitTemperature)
        {
            // ...do this.
            print("Coffee is to hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is to cold.");
        }
        // if it is neither of those then...
        else
        {
            //...do this.
            print("Coffee is just right.");
        }
    }
}
