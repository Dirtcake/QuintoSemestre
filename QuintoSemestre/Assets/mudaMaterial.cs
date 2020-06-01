using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaMaterial : MonoBehaviour
{
    public Material certo, errado;
    MeshRenderer renderer;

    public void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }
    public void Update()
    {
        if (cristaoChao.errou_plataforma == true)
            renderer.material = errado;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            renderer.material = certo;
    }
}
