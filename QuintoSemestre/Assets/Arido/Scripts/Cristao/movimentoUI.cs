using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimentoUI : MonoBehaviour
{
    public void MoverUI()
    {
        if(controleMandamentos.arrastando == false)
        this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}
