using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{

    public float LifeValue;
    public float LifeMax;

    [SerializeField] public Image lifeImage;
    // Start is called before the first frame update
    void Start()
    {
        LifeValue = LifeMax;
    }

    // Update is called once per frame
    void Update()
    {
        lifeImage.fillAmount = LifeValue/LifeMax;
    }

}
