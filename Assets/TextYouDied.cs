using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextYouDied : MonoBehaviour
{

    public Life Life;
    public Text MyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Life.LifeValue <= 0)
        {
            MyText.text = "You died!";
        }
        else
        {
            MyText.text = "";
        }
    }
}
