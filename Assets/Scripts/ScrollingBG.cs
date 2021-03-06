﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    private float x, y, newX, newY;
    private float offsetX = 50f;
    private float offsetY = 20.0f;
    private float displacement = 50f;
    public GameObject background;
    private GameObject[] backgroundInst = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        x = gameObject.transform.position.x;
        newX = x;
        backgroundInst[0] = Instantiate(background, gameObject.transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
        backgroundInst[1] = Instantiate(background, gameObject.transform.position, Quaternion.identity);
        backgroundInst[2] = Instantiate(background, gameObject.transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);

    }

    void checkX() {
        if (newX >= x + offsetX)
        {
            if (backgroundInst[0].transform.position.x < backgroundInst[1].transform.position.x && backgroundInst[0].transform.position.x < backgroundInst[2].transform.position.x)
            {
                Object.Destroy(backgroundInst[0]);
                if (backgroundInst[1].transform.position.x > backgroundInst[2].transform.position.x)
                {
                    backgroundInst[0] = Instantiate(background, backgroundInst[1].transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
                else
                {
                    backgroundInst[0] = Instantiate(background, backgroundInst[2].transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
            }
            else if (backgroundInst[1].transform.position.x < backgroundInst[2].transform.position.x && backgroundInst[1].transform.position.x < backgroundInst[0].transform.position.x)
            {
                Object.Destroy(backgroundInst[1]);
                if (backgroundInst[0].transform.position.x > backgroundInst[2].transform.position.x)
                {
                    backgroundInst[1] = Instantiate(background, backgroundInst[0].transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
                else
                {
                    backgroundInst[1] = Instantiate(background, backgroundInst[2].transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
            }
            else
            {
                Object.Destroy(backgroundInst[2]);
                if (backgroundInst[1].transform.position.x > backgroundInst[0].transform.position.x)
                {
                    backgroundInst[2] = Instantiate(background, backgroundInst[1].transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
                else
                {
                    backgroundInst[2] = Instantiate(background, backgroundInst[0].transform.position + new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
            }
            x = newX;
        }

        else if (newX <= x - offsetX)
        {
            if (backgroundInst[0].transform.position.x > backgroundInst[1].transform.position.x && backgroundInst[0].transform.position.x > backgroundInst[2].transform.position.x)
            {
                Object.Destroy(backgroundInst[0]);
                if (backgroundInst[1].transform.position.x < backgroundInst[2].transform.position.x)
                {
                    backgroundInst[0] = Instantiate(background, backgroundInst[1].transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
                else
                {
                    backgroundInst[0] = Instantiate(background, backgroundInst[2].transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
            }
            else if (backgroundInst[1].transform.position.x > backgroundInst[2].transform.position.x && backgroundInst[1].transform.position.x > backgroundInst[0].transform.position.x)
            {
                Object.Destroy(backgroundInst[1]);
                if (backgroundInst[0].transform.position.x < backgroundInst[2].transform.position.x)
                {
                    backgroundInst[1] = Instantiate(background, backgroundInst[0].transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
                else
                {
                    backgroundInst[1] = Instantiate(background, backgroundInst[2].transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
            }
            else
            {
                Object.Destroy(backgroundInst[2]);
                if (backgroundInst[1].transform.position.x < backgroundInst[0].transform.position.x)
                {
                    backgroundInst[2] = Instantiate(background, backgroundInst[1].transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
                else
                {
                    backgroundInst[2] = Instantiate(background, backgroundInst[0].transform.position - new Vector3(displacement, 0.0f, 0.0f), Quaternion.identity);
                }
            }
            x = newX;
        }
    }

    // Update is called once per frame
    
    void Update()
    {
        newX = gameObject.transform.position.x;
        checkX();
    }
    
}
