﻿using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour
{

    public int shieldTime, color;
    public Sprite greenShield, redShield, blueShield, purpleShield;

    private float hurtTimer;
    private GameObject player;

    // Use this for initialization
    void Start()
    {
        //set color of shield
        if (player.GetComponent<Player>().color == 0)//if color is green set sprite to green and set color to green
        {
            this.GetComponent<SpriteRenderer>().sprite = greenShield;
            color = 0;
        }
        else if (player.GetComponent<Player>().color == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = redShield;
            color = 1;
        }
        else if (player.GetComponent<Player>().color == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = blueShield;
            color = 2;
        }
        else if (player.GetComponent<Player>().color == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = purpleShield;
            color = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //follow players location
        this.GetComponent<Transform>().position = player.GetComponent<Transform>().position;

        hurtTimer += 1.0F * Time.deltaTime;
        if (hurtTimer >= shieldTime)
        {
            //remove shield and make player unhurt
            player.GetComponent<Player>().Unhurt();
            GameObject.Destroy(gameObject);
        }

        //follow players location
        this.GetComponent<Transform>().position = player.GetComponent<Transform>().position;
    }

    public void setPlayer(GameObject player)
    {
        this.player = player;
    }
}
