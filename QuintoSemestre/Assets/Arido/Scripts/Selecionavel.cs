using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecionavel : MonoBehaviour
{
    MeshRenderer renderer;
    bool selecionado;

    public Material M_selecionado, M_descelecionado;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
    }

    private void LateUpdate()
    {
        if (selecionado){
            renderer.material = M_selecionado;
        }

        else{
            renderer.material = M_descelecionado;
        }

        selecionado = false;
    }

    public void Selecionar(){
        selecionado = true;
    }

    
}
