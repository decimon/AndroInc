using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public UnityEngine.UI.Button Search;
    public UnityEngine.UI.Button YellowInc;
    public UnityEngine.UI.Text goldDisplay;

    // Update is called once per frame
    void Update () {
        goldDisplay.text = Click.gold.ToString("f0") + " Rubin";
	
	}
    public void Clicked()
    {
        Search.gameObject.SetActive(true);
        YellowInc.gameObject.SetActive(false);
    }
    public void Upgrades()
    {
        Search.gameObject.SetActive(false);
        YellowInc.gameObject.SetActive(true);
    }


}
