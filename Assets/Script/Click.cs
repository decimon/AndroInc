using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	// Use this for initialization
	
        
        public static double gold = 0.0f;
        public double goldperclick = 1;
        RectTransform tran;
        void Start()
        {
            tran = GetComponent<RectTransform>();
        }




        // Update is called once per frame
        void Update () {
        
	
	}
    public void Clicked()
    {
        Search();
        
        
        

    }

    private void Search()
    {
        if (Random.Range(1,1000) <= RubinPercentage.bluePer )
        {
            gold += RubinPercentage.blue;
            return;

        }
        if (Random.Range(1, 1000) <= RubinPercentage.redPer)
        {
            gold += RubinPercentage.red;
            return;

        }
        if (Random.Range(1, 1000) <= RubinPercentage.yellowPer)
        {
            gold += RubinPercentage.yellow;
            return;

        }
        else
        {
            return;
        }
    }

    





}
