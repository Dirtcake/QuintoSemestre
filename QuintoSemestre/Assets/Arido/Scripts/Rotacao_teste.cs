using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_teste : MonoBehaviour {
    void Start () {
        from = transform;
        to = from;
    }

    void Update () {
        Lerp_rotate();
    }

    Transform from, to;
    float contador;
    void Lerp_rotate () {

        if (contador < Time.time) {
            to.transform.eulerAngles += 90 * Vector3.up;
            contador = Time.time + 4;
        }

        transform.rotation = Quaternion.Slerp (from.rotation, to.rotation, 0.1f);

    }
}