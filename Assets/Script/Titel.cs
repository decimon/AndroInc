using UnityEngine;
using System.Collections;

public class Titel : MonoBehaviour


{

    float h = Screen.height;
    RectTransform tran;

    // Use this for initialization
    void Start()
    {

        tran = GetComponent<RectTransform>();

        

        transform.position = new Vector2(Screen.width / 2, h * 0.9f);
        tran.sizeDelta = new Vector2(Screen.width * 0.5f, Screen.height * 0.15f);
        
       // transform.localScale = new Vector2(Screen.width * 0.003f,Screen.height * 0.002f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
