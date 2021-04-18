using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] 
    private float _speed = 5;
    [SerializeField] 
    private GameObject _vaccinePrefab;
    [SerializeField] 
    private float vaccinationrate = 0.4f;

    private float _canvaccinate = -1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Playermovement();
        Boundaries();
        Vaccinate();
    }

    void Playermovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime*_speed*horizontalInput);
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up *Time.deltaTime* _speed* verticalInput);
    }

    void Vaccinate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time> _canvaccinate)
        {
            Instantiate(_vaccinePrefab, transform.position + new Vector3(0,0.6f,0), Quaternion.identity);
            _canvaccinate = Time.time + vaccinationrate;
        } 
    }
    void Boundaries()
    {
        if (transform.position.x <= -10.2f)
        {
            transform.position = new Vector3(-10.2f, transform.position.y, 0f);
        }
        if (transform.position.x >= 10.2f)
        {
            transform.position = new Vector3(10.2f, transform.position.y, 0f);
        }

        if (transform.position.y <= -3.9f) 
        {
            transform.position = new Vector3(transform.position.x, -3.9f, 0f);
        }
        if (transform.position.y >= 6f)
        {
            transform.position = new Vector3(transform.position.x, 6f, 0f);
        }
    }

    
}
