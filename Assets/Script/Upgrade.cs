using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    public UnityEngine.UI.Text cost;
    public UnityEngine.UI.Text current;

    // Update is called once per frame
    void Update () {
        cost.text = RubinPercentage.yCost.ToString("f0") + " Rubin";
        current.text ="Current " + RubinPercentage.yellow.ToString("f1") + " Rubin";

    }

    public void YellowAmountUpgrade()
    {
        
            RubinPercentage.YellowUp();

        


    }
}
