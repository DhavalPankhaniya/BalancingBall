using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public static bool isFired;

    // Use this for initialization
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }
        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
