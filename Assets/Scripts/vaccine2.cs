using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaccine2 : MonoBehaviour

{
    [SerializeField] private float _vaccspeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _vaccspeed);
        if (transform.position.y > 7)
        {
            Destroy(this.gameObject);
        }
    }
}
