using UnityEngine;
using System.Collections;

public class RubinPercentage : MonoBehaviour {

    public static float bluePer = 10.0f;
    public static double redPer = 70.0f;
    public static double yellowPer = 800.0f;

    public static double yellow = 1.0f;
    public static double red = 10.0f;
    public static double blue = 100.0f;

    public static double yCost = 10.0f;
    public static double yMultiplicator = 1.4f;
    public static double _newCost = 1.2f;

    // Update is called once per frame
    void Update () {
	
	}

    public static void YellowUp()
    {
        if (Click.gold >= yCost)
        {
            yellow = yellow * yMultiplicator;
            Click.gold -= yCost;
            yCost = yCost * _newCost;
        }
        
    }

    
}
