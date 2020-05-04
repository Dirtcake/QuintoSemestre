using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoFalso : MonoBehaviour
{
    public Vector3 caiu;
    public Vector3 normal;
    void Start()
    {
        normal = transform.position;
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collider col )
    {
       
    }
}
