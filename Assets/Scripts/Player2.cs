using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private float test_speed = 5;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject _capsuletest;

    [SerializeField] private float vaccinrate=0.4f;
    private float canvaccinate = -1f;
    
    void Start()
    {
        transform.position = new Vector3(1, 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        movement();
        boundaries();
        if ((Input.GetKeyDown(KeyCode.Space)) && Time.time > canvaccinate)
        {
            Instantiate(_capsuletest, transform.position, Quaternion.identity);
            canvaccinate = Time.time + vaccinrate;
        }
    }

    void movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalmove * Time.deltaTime*test_speed);
        float verticalmove = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalmove * Time.deltaTime*test_speed);
    }

    void boundaries()
    {
        if (transform.position.x <= -9.88f)
        {
            transform.position = new Vector3(-9.8f, transform.position.y, 0);
        }

        if (transform.position.x >= 10.2f)
        {
            transform.position = new Vector3(10.2f, transform.position.y, 0);
        }
        if (transform.position.y <= -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }
        if (transform.position.y >= 6.1f)
        {
            transform.position = new Vector3(transform.position.x, 6.1f, 0);
        }  
    }
}
