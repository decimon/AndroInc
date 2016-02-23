using UnityEngine;
using System.Collections;

public class Upgrades : MonoBehaviour {

    RectTransform tran;

    // Use this for initialization
    void Start()
    {

        tran = GetComponent<RectTransform>();
        tran.sizeDelta = new Vector2(Screen.width / 2, Screen.height * 0.05f);
        transform.position = new Vector2(Screen.width * 0.75f , Screen.height * 0.8f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}