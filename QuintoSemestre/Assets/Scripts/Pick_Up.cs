using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up : MonoBehaviour
{
    public Transform dest;
    Rigidbody item_gravity;
    BoxCollider item_collider;
    // Start is called before the first frame update

    void OnMouseDown()
    {
        item_collider = GetComponent<BoxCollider>();
       // item_collider.enabled = false;

       item_gravity = GetComponent<Rigidbody>();
       item_gravity.useGravity = false;

        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("Guide").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        item_collider.enabled = true;
        item_gravity.useGravity = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
