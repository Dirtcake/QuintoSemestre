using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecionavel : MonoBehaviour
{
  

    MeshRenderer renderer;
    bool selecionado;

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
            renderer.material.SetColor("_EmissionColor", Color.grey);
            renderer.material.EnableKeyword("_EMISSION");
        }

        else{
            renderer.material.DisableKeyword("_EMISSION"); 
        }

        selecionado = false;
    }

    public void Selecionar(){
        selecionado = true;
    }

    
}
