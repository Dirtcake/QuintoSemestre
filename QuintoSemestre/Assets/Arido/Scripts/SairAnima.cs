using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SairAnima : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(gameObject);
        }
    }

}
