using UnityEngine;
using System.Collections;

public class UI_YellowInc : MonoBehaviour {

    RectTransform tran;
    // Use this for initialization
    void Start()
    {
        tran = GetComponent<RectTransform>();
        tran.sizeDelta = new Vector2(Screen.width / 2.5f, Screen.height * 0.1f);
        transform.position = new Vector2(Screen.width / 4, Screen.height * 0.6f);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
