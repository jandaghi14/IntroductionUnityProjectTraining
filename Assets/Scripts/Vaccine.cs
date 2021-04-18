using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaccine : MonoBehaviour
{
    [SerializeField] 
    private float _Vaccinespeed = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime *_Vaccinespeed);
        if (transform.position.y > 7f)
        {
            Destroy(this.gameObject);
        }
    }
}
