using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Life Life;
    public SpriteRenderer playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Life.LifeValue <= 0)
        {
            Debug.Log("Je suis mort !");
            playerSprite.color = Color.red;
        } else
        {
            playerSprite.color = Color.white;
        }
    } 
}
