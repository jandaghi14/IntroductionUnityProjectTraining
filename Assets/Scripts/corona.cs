using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class corona : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cronavirus;
    [SerializeField]private float virusproduct = 1.4f;
    private float canvirusproduct = -1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > canvirusproduct)
        {
            Instantiate(cronavirus, new Vector3(Random.Range(-9f, 9f), 7.46f, 0f), Quaternion.identity);
            canvirusproduct = Time.time + virusproduct;
        }
    }

    
}
