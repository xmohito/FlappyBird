using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=_speed * Vector3.left * Time.deltaTime;
    }
}
