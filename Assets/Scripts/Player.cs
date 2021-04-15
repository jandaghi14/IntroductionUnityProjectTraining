using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime*_speed*horizontalInput);
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up *Time.deltaTime* _speed* verticalInput);
    }
    
}
