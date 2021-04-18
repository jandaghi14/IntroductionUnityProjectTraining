using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
    [SerializeField] private float _speedvirus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down*Time.deltaTime*_speedvirus);
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Vaccine"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
