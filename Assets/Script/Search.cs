using UnityEngine;
using System.Collections;

public class Search : MonoBehaviour {
    RectTransform tran;
    // Use this for initialization
    void Start () {
        tran = GetComponent<RectTransform>();
        tran.sizeDelta = new Vector2(Screen.height * 0.6f * 0.75f * 1.7f, Screen.height * 0.4f * 1.7f);
        transform.position = new Vector2(Screen.width/2, Screen.height * 0.4f);
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
